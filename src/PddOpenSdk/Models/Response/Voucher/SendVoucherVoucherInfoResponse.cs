namespace PddOpenSdk.Models.Response.Voucher;
public partial class SendVoucherVoucherInfoResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("voucher_voucher_info_send_response")]
    public VoucherVoucherInfoSendResponseResponse VoucherVoucherInfoSendResponse { get; set; }

    public partial class VoucherVoucherInfoSendResponseResponse
    {

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

