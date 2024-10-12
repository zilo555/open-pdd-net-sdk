namespace PddOpenSdk.Models.Response.Voucher;
public partial class SendVoucherAppointmentInfoResponse
{

    /// <summary>
    /// voucher_appointment_info_send_response
    /// </summary>
    [JsonPropertyName("voucher_appointment_info_send_response")]
    public VoucherAppointmentInfoSendResponseResponse VoucherAppointmentInfoSendResponse { get; set; }

    public partial class VoucherAppointmentInfoSendResponseResponse
    {

        /// <summary>
        /// is_success
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

