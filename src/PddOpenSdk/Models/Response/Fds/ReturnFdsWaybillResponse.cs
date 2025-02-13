namespace PddOpenSdk.Models.Response.Fds;
public partial class ReturnFdsWaybillResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_waybill_return_response")]
    public PddFdsWaybillReturnResponseResponse? PddFdsWaybillReturnResponse { get; set; }

    public partial class PddFdsWaybillReturnResponseResponse
    {

        /// <summary>
        /// 回传结果true:成功false：失败
        /// </summary>
        [JsonPropertyName("return_result")]
        public bool? ReturnResult { get; set; }


    }

}

