namespace PddOpenSdk.Models.Response.DdkTools;
public partial class QueryDdkOauthMemberAuthorityResponse
{

    /// <summary>
    /// 查询结果
    /// </summary>
    [JsonPropertyName("authority_query_response")]
    public AuthorityQueryResponseResponse AuthorityQueryResponse { get; set; }

    public partial class AuthorityQueryResponseResponse
    {

        /// <summary>
        /// 1-已绑定；0-未绑定
        /// </summary>
        [JsonPropertyName("bind")]
        public int? Bind { get; set; }


    }

}

