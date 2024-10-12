namespace PddOpenSdk.Models.Response.Fds;
public partial class GetFdsRoleResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_role_get_response")]
    public PddFdsRoleGetResponseResponse PddFdsRoleGetResponse { get; set; }

    public partial class PddFdsRoleGetResponseResponse
    {

        /// <summary>
        /// 店铺身份 0：未知身份 2：厂家
        /// </summary>
        [JsonPropertyName("mall_role")]
        public int? MallRole { get; set; }


    }

}

