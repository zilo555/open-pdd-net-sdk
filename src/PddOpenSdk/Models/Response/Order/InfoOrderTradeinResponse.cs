namespace PddOpenSdk.Models.Response.Order;
public partial class InfoOrderTradeinResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("order_activity_info_map")]
            public Dictionary<string, object>? OrderActivityInfoMap { get; set; }

            public partial class OrderActivityInfoMapResponse
            {

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("$key")]
                public string? Key { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [JsonPropertyName("$value")]
                public ValueResponse? Value { get; set; }

                public partial class ValueResponse
                {

                    /// <summary>
                    /// 是否是一店多地订单
                    /// </summary>
                    [JsonPropertyName("is_one_store_multi_region_order")]
                    public bool? IsOneStoreMultiRegionOrder { get; set; }

                    /// <summary>
                    /// 是否需要绑定SN码
                    /// </summary>
                    [JsonPropertyName("need_bind_sn_code")]
                    public bool? NeedBindSnCode { get; set; }

                    /// <summary>
                    /// 是否需要上传SN码
                    /// </summary>
                    [JsonPropertyName("need_upload_sn_code")]
                    public bool? NeedUploadSnCode { get; set; }

                    /// <summary>
                    /// 补贴政府区信息
                    /// </summary>
                    [JsonPropertyName("sponsor_city_name")]
                    public string? SponsorCityName { get; set; }

                    /// <summary>
                    /// 补贴政府城市信息
                    /// </summary>
                    [JsonPropertyName("sponsor_district_name")]
                    public string? SponsorDistrictName { get; set; }

                    /// <summary>
                    /// 补贴政府省份信息
                    /// </summary>
                    [JsonPropertyName("sponsor_province_name")]
                    public string? SponsorProvinceName { get; set; }

                    /// <summary>
                    /// 订单分店mallid
                    /// </summary>
                    [JsonPropertyName("sub_mall_id")]
                    public long? SubMallId { get; set; }

                    /// <summary>
                    /// 订单分店名
                    /// </summary>
                    [JsonPropertyName("sub_mall_name")]
                    public string? SubMallName { get; set; }

                    /// <summary>
                    /// 补贴是否生效
                    /// </summary>
                    [JsonPropertyName("subsidy_effective")]
                    public bool? SubsidyEffective { get; set; }


                }

            }

        }

    }

}

