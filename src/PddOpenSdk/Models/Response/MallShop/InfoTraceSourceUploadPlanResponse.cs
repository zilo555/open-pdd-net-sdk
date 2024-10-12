namespace PddOpenSdk.Models.Response.MallShop;
public partial class InfoTraceSourceUploadPlanResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }


    }

}

