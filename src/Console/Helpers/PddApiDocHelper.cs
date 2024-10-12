namespace Console.Helpers;

/// <summary>
/// 拼多多接口获取帮助类
/// </summary>
public class PddApiDocHelper
{
    /// <summary>
    /// 分类列表
    /// </summary>
    private readonly string ListUrl = "https://open-api.pinduoduo.com/pop/doc/category/list";

    /// <summary>
    /// 某分类下接口列表
    /// </summary>
    private readonly string CatUrl = "https://open-api.pinduoduo.com/pop/doc/info/list/byCat";

    /// <summary>
    /// 接口详情内容
    /// </summary>
    private readonly string DocInfoUrl = "https://open-api.pinduoduo.com/pop/doc/info/get";

    public List<PddCatInfo> PddCatInfos { get; set; } = [];
    public List<PddDocInfo> PddDocInfos { get; set; } = [];
    /// <summary>
    /// 目录与类名映射
    /// </summary>
    public Dictionary<string, string> CatMapClassName = [];

    public PddApiDocHelper()
    {
        #region 初始化映射类名
        CatMapClassName.Add("1", "Order");
        CatMapClassName.Add("2", "Refund");
        CatMapClassName.Add("3", "Logistics");
        CatMapClassName.Add("4", "Virtual");
        CatMapClassName.Add("5", "Goods");

        CatMapClassName.Add("12", "Ddk");
        CatMapClassName.Add("13", "DdkTools");
        CatMapClassName.Add("14", "LogisticsCompany");
        CatMapClassName.Add("15", "Promotion");
        CatMapClassName.Add("16", "Voucher");
        CatMapClassName.Add("17", "Invoice");
        CatMapClassName.Add("18", "MallShop");

        CatMapClassName.Add("20", "Util");
        CatMapClassName.Add("21", "Stock");
        CatMapClassName.Add("22", "Pmc");
        CatMapClassName.Add("23", "WayBill");
        CatMapClassName.Add("24", "Finance");
        CatMapClassName.Add("26", "OpenMsg");
        CatMapClassName.Add("30", "ServiceMarket");
        CatMapClassName.Add("32", "SmsVendor");

        //CatMapClassName.Add("35", "User");
        CatMapClassName.Add("41", "Ad");
        CatMapClassName.Add("43", "Fds");
        CatMapClassName.Add("46", "Mall");
        CatMapClassName.Add("48", "Oversea");
        CatMapClassName.Add("49", "Ticket");
        CatMapClassName.Add("50", "Ktt");
        // === 待定
        //CatMapClassName.Add("51", "");
        //CatMapClassName.Add("54", "PictureTool");
        // === 以下取消
        //CatMapClassName.Add("27", "Xinzhi");

        #endregion
    }

    /// <summary>
    /// 获取当前分类列表
    /// </summary>
    /// <returns></returns>
    public async Task<List<PddCatInfo>> GetCatListAsync()
    {
        using var hc = new HttpClient();
        try
        {
            var response = await hc.GetStringAsync(ListUrl);
            var result = JsonSerializer.Deserialize<ListResponseModel>(response);
            result.Result.Add(new PddCatInfo { Id = 50, Name = "快团团API" }); //新增快团团相关接口
            return result.Result;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            return [];
        }
    }

    /// <summary>
    /// 获取某类别下接口列表
    /// </summary>
    /// <param name="id">类别id</param>
    /// <returns></returns>
    public async Task<List<PddDocInfo>> GetApiDocListByCatAsync(long id)
    {
        using (var hc = new HttpClient())
        {
            var requestContent = new StringContent(JsonSerializer.Serialize(new { id }), Encoding.UTF8,
                                                   "application/json");
            var response = await hc.PostAsync(CatUrl, requestContent);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CatListResponseModel>(json);
                return result?.Result.DocList ?? [];
            }
        }
        return [];
    }

    /// <summary>
    /// 获取接口详细信息
    /// </summary>
    /// <param name="id">类别id</param>
    /// <returns></returns>
    public async Task<ApiDocDetail?> GetDocDetailByIdAsync(string id)
    {
        using var hc = new HttpClient();
        var requestContent = new StringContent(JsonSerializer.Serialize(new { id }), Encoding.UTF8,
                                               "application/json");
        var response = await hc.PostAsync(DocInfoUrl, requestContent);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ApiDocResponseModel>(json);
            return result?.Result;
        }
        return default;
    }

    public async Task TestApi(string id)
    {
        var currentPath = Directory.GetCurrentDirectory();
        var resultPath = Path.Combine(currentPath, "Services", "PddApi");
        // 创建目录
        if (!Directory.Exists(resultPath))
        {
            Directory.CreateDirectory(resultPath);
        }
        var docDetail = await GetDocDetailByIdAsync(id);
        var className = docDetail.ScopeName;
        className = className.Split(".")[1] ?? "UnNamed";
        var methodsContent = BuildRequestMethod(docDetail, className);
        SaveApiClass(className, methodsContent);
    }
    /// <summary>
    /// 全量生成所有接口模型及请求类
    /// </summary>
    /// <returns></returns>
    public async Task Run(bool isUpdate = false)
    {
        var totalNumber = 0;
        PddCatInfos = await GetCatListAsync();
        if (PddCatInfos.Count > 0)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var resultPath = Path.Combine(currentPath, "Services", "PddApi");
            // 创建目录
            if (!Directory.Exists(resultPath))
            {
                Directory.CreateDirectory(resultPath);
            }
            await Parallel.ForEachAsync(PddCatInfos, new ParallelOptions {
                MaxDegreeOfParallelism = 3
            }, async (pddCatInfo, token) => {
                PddDocInfos = await GetApiDocListByCatAsync(pddCatInfo.Id);
                // 获取映射类名
                CatMapClassName.TryGetValue(pddCatInfo.Id.ToString(), out var className);

                if (PddDocInfos.Count > 0)
                {
                    var methodsContent = "";
                    className ??= "UnNamed";
                    foreach (var pddDocInfo in PddDocInfos)
                    {
                        totalNumber++;
                        // 是否只获取更新的接口
                        if (isUpdate)
                        {
                            if (!pddDocInfo.ScopeTips.ToLower().Equals("new"))
                            {
                                return;
                            }
                        }
                        var docDetail = await GetDocDetailByIdAsync(pddDocInfo.Id);
                        methodsContent += BuildRequestMethod(docDetail, className);
                        System.Console.WriteLine($"[{totalNumber}]" + docDetail.ScopeName + "...✅");
                    }
                    SaveApiClass(className, methodsContent);
                }
            });
            System.Console.WriteLine("Get All " + totalNumber + " Api ✅");
        }
    }

    /// <summary>
    /// 生成接口请求方法
    /// </summary>
    /// <param name="requestClassName">请求类名称</param>
    /// <param name="doc"></param>
    public string BuildRequestMethod(ApiDocDetail doc, string requestClassName = "")
    {
        // 方法命名
        var scopeName = doc.ScopeName.Split('.');
        var methodName = Function.ToPascalCase(scopeName.Last());
        for (var i = 1; i < scopeName.Length - 1; i++)
        {
            methodName += Function.ToPascalCase(scopeName[i]);
        }
        var indentBuilder = new IndentBuilder(4);
        // 方法参数
        var methodComment =
$@"
/// <summary>
/// {doc.ApiName}
/// </summary>
";
        string methodParams;

        // 创建请求模型类
        var paramsModelType = methodName;
        var requestContent = BuildRequestModel(paramsModelType, doc.RequestParamList);
        SaveRequestModel(paramsModelType, requestContent, requestClassName);
        var paramsModelName = methodName.First().ToString().ToLower() + methodName[1..];
        methodParams = paramsModelType + " " + paramsModelName;

        // 创建返回模型类
        var responseModelName = methodName + "Response";
        // 根据返回示例生成
        var responseContent = BuildResponseModel(responseModelName, doc.ResponseParamList);

        if (string.IsNullOrEmpty(responseContent))
        {
            File.AppendAllText("error.txt", doc.ScopeName + "; catId:" + doc.CatId + doc.ResponseCodeExample + "\r\n");
        }
        SaveResponseModel(responseModelName, responseContent, requestClassName);

        var postName = "PostAsync";
        // 如果是文件类型
        if (doc.RequestParamList.Any(p => p.ParamType == "FILE"))
        {
            postName = "PostFileAsync";
        }
        indentBuilder.AppendLine(methodComment);
        indentBuilder.AppendLine($@"public async Task<{responseModelName}> {methodName}Async({methodParams})");
        indentBuilder.AppendLine("{");
        indentBuilder.IndentLine($@"var result = await {postName}<{paramsModelType}, {responseModelName}>(""{doc.ScopeName}"", {paramsModelName});");
        indentBuilder.AppendLine("return result;");
        indentBuilder.UnIndentLine("}");
        return indentBuilder.ToString();
    }

    /// <summary>
    /// 生成请求类型
    /// </summary>
    /// <param name="paramLists"></param>
    /// <param name="className"></param>
    /// <param name="level"></param>
    /// <returns></returns>
    public string BuildRequestModel(string className, List<ParamList> paramLists, int parentId = 0)
    {
        if (string.IsNullOrEmpty(className))
        {
            return string.Empty;
        }
        className = className.Replace("$", "");

        var suffix = "Model";
        var currentParamLists = paramLists.Where(p => p.ParentId == parentId).ToList();
        var indentBuilder = new IndentBuilder();

        indentBuilder.AppendLine($"public partial class {className}");
        indentBuilder.AppendLine("{");

        var paramsContent = "";
        var childClass = "";
        foreach (var param in currentParamLists)
        {
            // 对文件属性名进行特殊处理
            if (param.ParamType == "FILE")
            {
                param.ParamName = "file_path";
            }

            var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), param.IsMust.Value, suffix, hasChild: param.ChildrenNum > 0);

            var paramName = Function.ToPascalCase(param.ParamName.Replace("_", " "))?.Replace(" ", "")?.Replace("$", "");
            // 如果是对象类型，生成子类模型
            if (param.ChildrenNum > 0)
            {
                childClass += BuildRequestModel(paramName + suffix, paramLists, (int)param.Id);
            }

            // 参数注释
            var propertyContent =
$"""
/// <summary>
/// {param.ParamDesc?.Replace("\n", "; ")}
/// </summary>
[JsonPropertyName("{param.ParamName}")]
{attribution}

""";
            paramsContent += propertyContent;
        }
        indentBuilder.IndentLine(paramsContent);
        indentBuilder.AppendLine(childClass);
        indentBuilder.UnIndentLine("}");
        return indentBuilder.ToString();
    }

    /// <summary>
    /// 生成响应类型
    /// </summary>
    /// <param name="className"></param>
    /// <param name="paramLists"></param>
    /// <param name="level"></param>
    /// <returns></returns>
    public string BuildResponseModel(string className, List<ParamList> paramLists, int parentId = 0)
    {
        if (string.IsNullOrEmpty(className))
        {
            return string.Empty;
        }
        var currentParamLists = paramLists.Where(p => p.ParentId == parentId).ToList();
        var indentBuilder = new IndentBuilder();

        indentBuilder.AppendLine($"public partial class {className}");
        indentBuilder.AppendLine("{");
        var paramsContent = "";
        var childClass = "";
        foreach (var param in currentParamLists)
        {

            var attribution = NameHelper.GetAttributionName(param.ParamName, ConvertParamType(param.ParamType), 0, "Response", param.ChildrenNum > 0);

            var paramName = Function.ToPascalCase(
                param.ParamName.Replace("_", " "))?
                .Replace(" ", "")?
                .Replace("$", "");
            // 如果是对象类型，生成子类模型
            if (param.ChildrenNum > 0)
            {
                var childClassName = paramName + "Response";
                if (childClassName == className)
                {
                    childClassName = "Inner" + childClassName;
                }
                childClass += BuildResponseModel(childClassName, paramLists, (int)param.Id);
            }
            // 参数注释
            var paramComment =
$@"
/// <summary>
/// {param.ParamDesc?.Replace(Environment.NewLine, "; ")}
/// </summary>
[JsonPropertyName(""{param.ParamName}"")]
";
            paramsContent += paramComment + attribution;
        }
        indentBuilder.IndentLine(paramsContent);
        indentBuilder.AppendLine(childClass);
        indentBuilder.UnIndentLine("}");
        return indentBuilder.ToString();
    }

    /// <summary>
    /// 保存请求模型类
    /// </summary>
    /// <param name="className"></param>
    /// <param name="classContent"></param>
    protected void SaveRequestModel(string className, string classContent, string dir = "")
    {
        var currentPath = Directory.GetCurrentDirectory();
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Models", "Request", dir);
        // 创建目录
        if (!Directory.Exists(resultPath))
        {
            Directory.CreateDirectory(resultPath);
        }
        // 处理content为空的情况
        if (string.IsNullOrEmpty(classContent))
        {
            classContent = $@"public class {className}{{}}";
        }

        if (!string.IsNullOrEmpty(dir))
        {
            dir = "." + dir;
        }

        var namespaceBlock = Function.AppendLine("", $"using PddOpenSdk.Models.Request;");
        namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Request{dir};");
        classContent = Function.AppendLine(classContent, namespaceBlock, true);
        var fileName = className;
        File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
    }

    /// <summary>
    /// 自动生成接口返回类
    /// </summary>
    protected void SaveResponseModel(string className, string classContent, string dir = "")
    {
        var currentPath = Directory.GetCurrentDirectory();
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Models", "Response", dir);
        // 创建目录
        if (!Directory.Exists(resultPath))
        {
            Directory.CreateDirectory(resultPath);
        }
        // 处理content为空的情况
        if (string.IsNullOrEmpty(classContent))
        {
            classContent = $@"public class {className}{{}}";
        }

        if (!string.IsNullOrEmpty(dir))
        {
            dir = "." + dir;
        }

        var namespaceBlock = Function.AppendLine("", "using PddOpenSdk.Models.Response;");
        namespaceBlock = Function.AppendLine(namespaceBlock, $"namespace PddOpenSdk.Models.Response{dir};");
        classContent = Function.AppendLine(classContent, namespaceBlock, true);

        var fileName = className;
        File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), classContent);
    }

    /// <summary>
    /// 保存接口请求类
    /// </summary>
    /// <param name="className"></param>
    protected void SaveApiClass(string className, string classContent)
    {
        var currentPath = Directory.GetCurrentDirectory();
        var resultPath = Path.Combine(currentPath, "..", "PddOpenSdk", "Services", "PddApi");

        var fileName = Function.ToPascalCase(className) + "Api";
        // 处理重复类名的情况

        var content = $$"""
            using PddOpenSdk.Models.Request.{{Function.ToPascalCase(className)}};
            using PddOpenSdk.Models.Response.{{Function.ToPascalCase(className)}};
            namespace PddOpenSdk.Services.PddApi;
            public class {{fileName}} : PddCommonApi 
            {
                public {{fileName}}(){}
                public {{fileName}}(string clientId, string clientSecret, string accessToken): base(clientId, clientSecret, accessToken){}
                {{classContent}}
            }

            """;
        File.WriteAllText(Path.Combine(resultPath, fileName + ".cs"), content);

    }

    /// <summary>
    /// 生成PddService服务类
    /// </summary>
    public async Task GeneratePddServiceClassAsync()
    {
        // 1 获取说明注释
        var catList = await GetCatListAsync();
        // 2 构造属性
        var propsContent = "";
        var indentBuilder = new IndentBuilder();
        indentBuilder.IndentLine("public AuthApi AuthApi { get; }");
        CatMapClassName.ToList().ForEach(cat => {
            var comment = """
/// <summary>
/// {cat.Name}
/// </summary>
""";
            indentBuilder.AppendLine(comment);
            if (!string.IsNullOrEmpty(cat.Value))
            {
                var propName = cat.Value;
                indentBuilder.AppendLine($"public {propName}Api {propName}Api {{ get; }}");
            }
        });

        propsContent = indentBuilder.ToString();
        indentBuilder.Reset();

        // 3 构造构造方法/options/set token
        var ctorContent = "AuthApi = new AuthApi(_options.ClientId, _options.ClientSecret, _options.AccessToken, _options.CallbackUrl);" + Environment.NewLine;
        var ctorOptionContent = "AuthApi = new AuthApi(options.ClientId, options.ClientSecret, options.AccessToken, options.CallbackUrl);" + Environment.NewLine;
        var setTokenContent = "";

        var indentSpaces = new string(' ', 8);
        CatMapClassName.ToList().ForEach(cat => {
            var apiName = cat.Value + "Api";
            ctorContent += indentSpaces + apiName + $" = new {apiName}(_options.ClientId, _options.ClientSecret, _options.AccessToken);" + Environment.NewLine;
            ctorOptionContent += indentSpaces + apiName + $" = new {apiName}(options.ClientId, options.ClientSecret, options.AccessToken);" + Environment.NewLine;
            setTokenContent += indentSpaces + apiName + ".AccessToken = accessToken;" + Environment.NewLine;
        });
        // 4 替换并写入
        var path = Path.Combine(Environment.CurrentDirectory, "PddService.cs.tpl");
        if (File.Exists(path))
        {
            var tplContent = File.ReadAllText(path);
            tplContent = tplContent.Replace("{{$Properties}}", propsContent)
                .Replace("{{$Ctor}}", ctorContent)
                .Replace("{{$CtorOption}}", ctorOptionContent)
                .Replace("{{$SetToken}}", setTokenContent);

            var currentPath = Directory.GetCurrentDirectory();
            var servicePath = Path.Combine(currentPath, "..", "AspNetCore", "PddService.cs");
            File.WriteAllText(servicePath, tplContent);
        }
    }

    /// <summary>
    /// 转换参数类型为C#表达
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    protected string ConvertParamType(string type)
    {
        return type.ToLower() switch {
            "file" => "string",
            "integer" => "int",
            "integer[]" => "int[]",
            "void" => "string",
            _ => type.ToLower(),
        };
    }
}
