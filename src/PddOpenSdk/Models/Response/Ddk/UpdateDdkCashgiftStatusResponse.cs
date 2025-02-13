namespace PddOpenSdk.Models.Response.Ddk;
public partial class UpdateDdkCashgiftStatusResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("update_cashgift_response")]
    public UpdateCashgiftResponseResponse? UpdateCashgiftResponse { get; set; }

    public partial class UpdateCashgiftResponseResponse
    {

        /// <summary>
        /// 多多礼金ID
        /// </summary>
        [JsonPropertyName("cash_gift_id")]
        public long? CashGiftId { get; set; }


    }

}

