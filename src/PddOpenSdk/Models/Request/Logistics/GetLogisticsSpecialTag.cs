namespace PddOpenSdk.Models.Request.Logistics;
public partial class GetLogisticsSpecialTag
{
    /// <summary>
    /// 快递公司编号
    /// </summary>
    [JsonPropertyName("logistics_id")]
    public int LogisticsId { get; set; }

    /// <summary>
    /// 快递运单号
    /// </summary>
    [JsonPropertyName("tracking_number")]
    public string TrackingNumber { get; set; }



}

