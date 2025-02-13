namespace Console.Helpers;

/// <summary>
/// 类名、参数名等帮助类
/// </summary>
public class NameHelper
{
    /// <summary>
    /// 获取属性名称
    /// </summary>
    /// <param name="name">参数名</param>
    /// <param name="type">参数类型</param>
    /// <param name="isMust">是否必须</param>
    /// <param name="hasChild">是否有子元素，有的话，才构建新对象</param>
    /// <returns></returns>
    public static string GetAttributionName(string name, string type, long isMust = 1, string modelType = "RequestModel", bool hasChild = true)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        string attributionName;
        var isArray = false;

        //name = name.ToLower();
        type = type.ToLower();
        // 名称转为Pascal命名
        name = Function.ToPascalCase(
            name.Replace("_", " "))
            .Replace(" ", "")
            .Replace("$", "");

        // 是否为数组
        if (type.Contains("[]"))
        {
            isArray = true;
            type = type.Replace("[]", "");
        }
        // 类型映射
        switch (type)
        {
            case "boolean":
                type = isMust == 0 ? "bool?" : "bool";
                break;
            case "int":
            case "long":
            case "double":
            case "string":
                type = isMust == 0 ? type + "?" : type;
                break;
            case "map":
                type = isMust == 0 ? "Dictionary<string, object>?" : "Dictionary<string, object>";
                break;
            case "object":
                if (hasChild)
                {
                    type = Function.ToPascalCase(name + modelType);
                }
                else
                {
                    type = "object";
                }
                break;
            default:
                type = Function.ToPascalCase(type);
                break;
        }
        if (isArray)
        {
            // 可使用复数形式
            type = isMust == 0 ? $"List<{type}>?" : $"List<{type}>";
        }
        attributionName = $"public {type} {name} {{ get; set; }}" + Environment.NewLine;
        return attributionName;
    }
}
