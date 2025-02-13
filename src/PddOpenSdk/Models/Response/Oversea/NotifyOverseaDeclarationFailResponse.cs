namespace PddOpenSdk.Models.Response.Oversea;
public partial class NotifyOverseaDeclarationFailResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("notify_exceeded_response")]
    public NotifyExceededResponseResponse? NotifyExceededResponse { get; set; }

    public partial class NotifyExceededResponseResponse
    {

        /// <summary>
        /// true=处理成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }


    }

}

