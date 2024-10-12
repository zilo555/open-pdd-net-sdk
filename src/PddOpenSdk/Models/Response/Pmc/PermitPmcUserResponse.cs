namespace PddOpenSdk.Models.Response.Pmc;
public partial class PermitPmcUserResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pmc_user_permit_response")]
    public PmcUserPermitResponseResponse PmcUserPermitResponse { get; set; }

    public partial class PmcUserPermitResponseResponse
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

