namespace PddOpenSdk.Models.Request.Order;
public partial class InfoOrderTradein
{
    /// <summary>
    /// 订单号列表
    /// </summary>
    [JsonPropertyName("order_sn_list")]
    public List<string> OrderSnList { get; set; }



}

