namespace PddOpenSdk.Models.Request.Logistics;
public partial class EnterConsoWarehousePackScan
{
    /// <summary>
    /// 操作账号
    /// </summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("track_no")]
    public string TrackNo { get; set; }

    /// <summary>
    /// 包裹重量，单位kg，格式为数字形式的字符串，最多3位小数
    /// </summary>
    [JsonPropertyName("weight")]
    public string? Weight { get; set; }



}

