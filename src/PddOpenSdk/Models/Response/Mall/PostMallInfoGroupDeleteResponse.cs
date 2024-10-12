namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupDeleteResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }


    }

}

