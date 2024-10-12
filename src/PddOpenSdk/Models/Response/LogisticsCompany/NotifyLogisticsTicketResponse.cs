namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class NotifyLogisticsTicketResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("logistics_ticket_notify_response")]
    public LogisticsTicketNotifyResponseResponse LogisticsTicketNotifyResponse { get; set; }

    public partial class LogisticsTicketNotifyResponseResponse
    {

        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

