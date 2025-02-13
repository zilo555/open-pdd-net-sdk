namespace PddOpenSdk.Models.Request.Order;
public partial class SnOrderTradeinPost
{
    /// <summary>
    /// req
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }


    public partial class RequestModel
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }



    }

}

