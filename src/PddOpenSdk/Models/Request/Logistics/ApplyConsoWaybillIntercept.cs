namespace PddOpenSdk.Models.Request.Logistics;
public partial class ApplyConsoWaybillIntercept
{
    /// <summary>
    /// 每次拦截请求的唯一标识
    /// </summary>
    [JsonPropertyName("apply_id")]
    public string ApplyId { get; set; }

    /// <summary>
    /// 拦截类型：1-退回, 2-拦截转寄
    /// </summary>
    [JsonPropertyName("intercept_type")]
    public int InterceptType { get; set; }

    /// <summary>
    /// 拦截原因
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// 收件人详细地址，不拼接省市区。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_address")]
    public string? ReceiverAddress { get; set; }

    /// <summary>
    /// 收件人所在城市。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_city")]
    public string? ReceiverCity { get; set; }

    /// <summary>
    /// 收件人所在地区。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_district")]
    public string? ReceiverDistrict { get; set; }

    /// <summary>
    /// 收件人姓名，姓名打码，拼接分机号。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_name")]
    public string? ReceiverName { get; set; }

    /// <summary>
    /// 收件人电话，电话为虚拟号。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_phone")]
    public string? ReceiverPhone { get; set; }

    /// <summary>
    /// 收件人所在省份。 仅当 intercept_type=2 时 不为空。
    /// </summary>
    [JsonPropertyName("receiver_province")]
    public string? ReceiverProvince { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("track_no")]
    public string TrackNo { get; set; }



}

