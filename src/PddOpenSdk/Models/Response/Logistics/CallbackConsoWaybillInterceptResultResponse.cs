namespace PddOpenSdk.Models.Response.Logistics;
public partial class CallbackConsoWaybillInterceptResultResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 错误码
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

