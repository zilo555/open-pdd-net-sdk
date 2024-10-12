namespace PddOpenSdk.Models.Response.DdkTools;
public partial class GenDdkOauthWeappQrcodeUrlResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("weapp_qrcode_generate_response")]
    public WeappQrcodeGenerateResponseResponse WeappQrcodeGenerateResponse { get; set; }

    public partial class WeappQrcodeGenerateResponseResponse
    {

        /// <summary>
        /// 单品推广小程序二维码url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }


    }

}

