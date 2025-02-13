namespace PddOpenSdk.Models.Response.Finance;
public partial class GetFinanceBalanceDailyBillUrlResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("finance_balance_daily_bill_url_get_response")]
    public FinanceBalanceDailyBillUrlGetResponseResponse? FinanceBalanceDailyBillUrlGetResponse { get; set; }

    public partial class FinanceBalanceDailyBillUrlGetResponseResponse
    {

        /// <summary>
        /// 货款账单下载 URL
        /// </summary>
        [JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }


    }

}

