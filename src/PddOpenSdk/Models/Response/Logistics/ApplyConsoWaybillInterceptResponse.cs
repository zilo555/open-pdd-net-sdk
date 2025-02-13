namespace PddOpenSdk.Models.Response.Logistics;
public partial class ApplyConsoWaybillInterceptResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 错误码。0-成功；1-非平台运单号；2-不满足拦截条件；3-包裹已被拦截(不同渠道)；4-包裹已被拦截(相同渠道)；10-系统内部错误
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }


    }

}

