namespace PddOpenSdk.Models.Response.Voucher;
public partial class SendVoucherPhysicalGoodsResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("voucher_physical_voucher_send_response")]
    public VoucherPhysicalVoucherSendResponseResponse VoucherPhysicalVoucherSendResponse { get; set; }

    public partial class VoucherPhysicalVoucherSendResponseResponse
    {

        /// <summary>
        /// 请求成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

