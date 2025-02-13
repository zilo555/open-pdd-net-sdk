namespace PddOpenSdk.Models.Request.Order;
public partial class GetOrderSpecificOrderInformation
{
    /// <summary>
    /// 订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }



}

