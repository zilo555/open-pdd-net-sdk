namespace PddOpenSdk.Models.Response.Logistics;
public partial class GetLogisticsSpecialTagResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 运单号标签列表，special_guarantee=专项保障
        /// </summary>
        [JsonPropertyName("tracking_number_tag_list")]
        public List<TrackingNumberTagListResponse?>? TrackingNumberTagList { get; set; }

        public partial class TrackingNumberTagListResponse
        {

            /// <summary>
            /// 标签名称
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// 是否有标签：0=无标签，1=有标签
            /// </summary>
            [JsonPropertyName("value")]
            public int? Value { get; set; }


        }

    }

}

