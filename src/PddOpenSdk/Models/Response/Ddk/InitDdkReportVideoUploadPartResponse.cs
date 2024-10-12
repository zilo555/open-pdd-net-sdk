namespace PddOpenSdk.Models.Response.Ddk;
public partial class InitDdkReportVideoUploadPartResponse
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
        [JsonPropertyName("upload_sign")]
        public string UploadSign { get; set; }


    }

}

