namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderConsolidateOrderUserAddressResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string? OrderSn { get; set; }

        /// <summary>
        /// 用户实际收货详细地址，不拼接省市区。
        /// </summary>
        [JsonPropertyName("user_receiving_address")]
        public string? UserReceivingAddress { get; set; }

        /// <summary>
        /// 用户实际收货城市
        /// </summary>
        [JsonPropertyName("user_receiving_city")]
        public string? UserReceivingCity { get; set; }

        /// <summary>
        /// 用户实际收货城市编码
        /// </summary>
        [JsonPropertyName("user_receiving_city_id")]
        public int? UserReceivingCityId { get; set; }

        /// <summary>
        /// 用户实际收货姓名
        /// </summary>
        [JsonPropertyName("user_receiving_name")]
        public string? UserReceivingName { get; set; }

        /// <summary>
        /// 用户实际收货手机号
        /// </summary>
        [JsonPropertyName("user_receiving_phone")]
        public string? UserReceivingPhone { get; set; }

        /// <summary>
        /// 用户实际收货省份
        /// </summary>
        [JsonPropertyName("user_receiving_province")]
        public string? UserReceivingProvince { get; set; }

        /// <summary>
        /// 用户实际收货省份编码
        /// </summary>
        [JsonPropertyName("user_receiving_province_id")]
        public int? UserReceivingProvinceId { get; set; }

        /// <summary>
        /// 用户实际收货区县
        /// </summary>
        [JsonPropertyName("user_receiving_town")]
        public string? UserReceivingTown { get; set; }

        /// <summary>
        /// 用户实际收货区县编码
        /// </summary>
        [JsonPropertyName("user_receiving_town_id")]
        public int? UserReceivingTownId { get; set; }


    }

}

