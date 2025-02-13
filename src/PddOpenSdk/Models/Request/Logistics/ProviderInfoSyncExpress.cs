namespace PddOpenSdk.Models.Request.Logistics;
public partial class ProviderInfoSyncExpress
{
    /// <summary>
    /// 详细地址
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 营业时间描述
    /// </summary>
    [JsonPropertyName("business_time_desc")]
    public string? BusinessTimeDesc { get; set; }

    /// <summary>
    /// 市
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// 联系方式
    /// </summary>
    [JsonPropertyName("contract_info")]
    public List<object>? ContractInfo { get; set; }

    /// <summary>
    /// 国家
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// 区
    /// </summary>
    [JsonPropertyName("district")]
    public string District { get; set; }

    /// <summary>
    /// 纬度
    /// </summary>
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    /// <summary>
    /// 经度
    /// </summary>
    [JsonPropertyName("lng")]
    public string Lng { get; set; }

    /// <summary>
    /// 拼多多平台代收点code，同一个供应商下唯一
    /// </summary>
    [JsonPropertyName("pdd_code")]
    public string PddCode { get; set; }

    /// <summary>
    /// 自提点类型: 0-自提点 1-自提柜
    /// </summary>
    [JsonPropertyName("pick_up_type")]
    public int PickUpType { get; set; }

    /// <summary>
    /// 省
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// 自提点名称
    /// </summary>
    [JsonPropertyName("site_name")]
    public string SiteName { get; set; }

    /// <summary>
    /// 同步时间，eg: "2024-01-01 12:12:12"
    /// </summary>
    [JsonPropertyName("sync_time")]
    public string SyncTime { get; set; }



}

