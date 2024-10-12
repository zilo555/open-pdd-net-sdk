namespace PddOpenSdk.Models.Response.DdkTools;
public partial class CreateDdkOauthCashgiftResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("create_cashgift_response")]
    public CreateCashgiftResponseResponse CreateCashgiftResponse { get; set; }

    public partial class CreateCashgiftResponseResponse
    {

        /// <summary>
        /// 礼金ID
        /// </summary>
        [JsonPropertyName("cash_gift_id")]
        public long? CashGiftId { get; set; }

        /// <summary>
        /// 创建结果
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }


    }

}

