namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoGroupAddResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 门店组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }


    }

}

