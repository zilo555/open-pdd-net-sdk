namespace PddOpenSdk.Models.Response.Ddk;
public partial class UploadDdkReportImgResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }


    }

}

