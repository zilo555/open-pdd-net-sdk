namespace PddOpenSdk.Models.Request.Order;
public partial class UpdateOrderServiceBenefit
{
    /// <summary>
    /// 操作类型； 添加服务对象编号:1； 修改服务对象编号:2
    /// </summary>
    [JsonPropertyName("operate_type")]
    public int OperateType { get; set; }

    /// <summary>
    /// 拼多多订单号
    /// </summary>
    [JsonPropertyName("order_sn")]
    public string OrderSn { get; set; }

    /// <summary>
    /// 外部服务单号
    /// </summary>
    [JsonPropertyName("out_service_order_sn")]
    public string OutServiceOrderSn { get; set; }

    /// <summary>
    /// 服务有效期单位； 年:1
    /// </summary>
    [JsonPropertyName("period_unit")]
    public int PeriodUnit { get; set; }

    /// <summary>
    /// 服务有效止期，时间戳（毫秒）
    /// </summary>
    [JsonPropertyName("service_effect_end_time")]
    public long ServiceEffectEndTime { get; set; }

    /// <summary>
    /// 服务有效起期，时间戳（毫秒）
    /// </summary>
    [JsonPropertyName("service_effect_start_time")]
    public long ServiceEffectStartTime { get; set; }

    /// <summary>
    /// 服务对象； 整机:1； 核心部件:2
    /// </summary>
    [JsonPropertyName("service_object")]
    public int ServiceObject { get; set; }

    /// <summary>
    /// 服务对象编号
    /// </summary>
    [JsonPropertyName("service_object_sn")]
    public string ServiceObjectSn { get; set; }

    /// <summary>
    /// 服务有效期
    /// </summary>
    [JsonPropertyName("service_period")]
    public int ServicePeriod { get; set; }

    /// <summary>
    /// 服务单类型;  设备延保:1
    /// </summary>
    [JsonPropertyName("service_type")]
    public int ServiceType { get; set; }



}

