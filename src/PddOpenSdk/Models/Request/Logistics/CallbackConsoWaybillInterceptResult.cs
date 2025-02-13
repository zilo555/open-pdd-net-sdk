namespace PddOpenSdk.Models.Request.Logistics;
public partial class CallbackConsoWaybillInterceptResult
{
    /// <summary>
    /// 每次拦截请求的唯一标识
    /// </summary>
    [JsonPropertyName("apply_id")]
    public string ApplyId { get; set; }

    /// <summary>
    /// 拦截失败原因
    /// </summary>
    [JsonPropertyName("fail_reason")]
    public string? FailReason { get; set; }

    /// <summary>
    /// 拦截结果。1-成功；2-失败；3-拦截进⾏中
    /// </summary>
    [JsonPropertyName("result_code")]
    public int ResultCode { get; set; }

    /// <summary>
    /// 运单号
    /// </summary>
    [JsonPropertyName("track_no")]
    public string TrackNo { get; set; }



}

