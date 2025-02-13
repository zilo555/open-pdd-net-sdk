namespace PddOpenSdk.Models.Response.Mall;
public partial class PostMallInfoStoreCreateResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("mall_info_store_create_post_response")]
    public MallInfoStoreCreatePostResponseResponse? MallInfoStoreCreatePostResponse { get; set; }

    public partial class MallInfoStoreCreatePostResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

