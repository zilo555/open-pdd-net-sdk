namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupUpdateResponse
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
        [JsonPropertyName("result")]
        public bool? Result { get; set; }


    }

}

