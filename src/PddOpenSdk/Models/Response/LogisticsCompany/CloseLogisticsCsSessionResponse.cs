namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class CloseLogisticsCsSessionResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_cs_session_close_response")]
    public LogisticsCsSessionCloseResponseResponse LogisticsCsSessionCloseResponse { get; set; }

    public partial class LogisticsCsSessionCloseResponseResponse
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

