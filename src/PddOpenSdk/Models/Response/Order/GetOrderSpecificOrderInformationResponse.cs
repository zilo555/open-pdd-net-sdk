namespace PddOpenSdk.Models.Response.Order;
public partial class GetOrderSpecificOrderInformationResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("specific_order_info")]
    public SpecificOrderInfoResponse? SpecificOrderInfo { get; set; }

    public partial class SpecificOrderInfoResponse
    {

        /// <summary>
        /// 售后状态 0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款，待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处理，退款失败 13：买家逾期，超过有效期 14：换货补寄待商家处理 15：换货补寄待用户处理 16：换货补寄成功 17：换货补寄失败 18：换货补寄待用户确认完成 21：待商家同意维修 22：待用户确认发货 24：维修关闭 25：维修成功 27：待用户确认收货 31：已同意拒收退款，待用户拒收 32：补寄待商家发货 33：同意召回后退款，待商家召回
        /// </summary>
        [JsonPropertyName("after_sales_status")]
        public int? AfterSalesStatus { get; set; }

        /// <summary>
        /// 买家留言信息
        /// </summary>
        [JsonPropertyName("buyer_memo")]
        public string? BuyerMemo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// 分批发货子单信息列表
        /// </summary>
        [JsonPropertyName("delivery_schedule_sub_order_list")]
        public List<DeliveryScheduleSubOrderListResponse?>? DeliveryScheduleSubOrderList { get; set; }

        /// <summary>
        /// 订单中商品sku列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ItemListResponse?>? ItemList { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_sn")]
        public string? OrderSn { get; set; }

        /// <summary>
        /// 发货状态，枚举值：1：待发货，2：已发货待签收，3：已签收
        /// </summary>
        [JsonPropertyName("order_status")]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// 退款状态，枚举值：1：无售后或售后关闭，2：售后处理中，3：退款中，4： 退款成功
        /// </summary>
        [JsonPropertyName("refund_status")]
        public int? RefundStatus { get; set; }

        /// <summary>
        /// 商家订单备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 订单备注标记，1-红色，2-黄色，3-绿色，4-蓝色，5-紫色
        /// </summary>
        [JsonPropertyName("remark_tag")]
        public int? RemarkTag { get; set; }

        /// <summary>
        /// 订单备注标记名称
        /// </summary>
        [JsonPropertyName("remark_tag_name")]
        public string? RemarkTagName { get; set; }

        /// <summary>
        /// 订单审核状态（0-正常订单， 1-审核中订单）
        /// </summary>
        [JsonPropertyName("risk_control_status")]
        public int? RiskControlStatus { get; set; }

        public partial class DeliveryScheduleSubOrderListResponse
        {

            /// <summary>
            /// 收件地城市
            /// </summary>
            [JsonPropertyName("city")]
            public string? City { get; set; }

            /// <summary>
            /// 城市编码
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 子单商品词条信息
            /// </summary>
            [JsonPropertyName("goods_entry_list")]
            public List<GoodsEntryListResponse?>? GoodsEntryList { get; set; }

            /// <summary>
            /// 子单承诺发货时间
            /// </summary>
            [JsonPropertyName("last_ship_time")]
            public string? LastShipTime { get; set; }

            /// <summary>
            /// 子单快递公司编号
            /// </summary>
            [JsonPropertyName("logistics_id")]
            public int? LogisticsId { get; set; }

            /// <summary>
            /// 收件地省份
            /// </summary>
            [JsonPropertyName("province")]
            public string? Province { get; set; }

            /// <summary>
            /// 省份编码
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 收件人地址，不拼接省市区。子单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串。
            /// </summary>
            [JsonPropertyName("receiver_address")]
            public string? ReceiverAddress { get; set; }

            /// <summary>
            /// 收件人姓名。子单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串
            /// </summary>
            [JsonPropertyName("receiver_name")]
            public string? ReceiverName { get; set; }

            /// <summary>
            /// 收件人电话。子单状态为待发货状态，且订单未被风控打标的情况下返回密文数据；其余情况返回空字符串。
            /// </summary>
            [JsonPropertyName("receiver_phone")]
            public string? ReceiverPhone { get; set; }

            /// <summary>
            /// 批次
            /// </summary>
            [JsonPropertyName("sequence_id")]
            public int? SequenceId { get; set; }

            /// <summary>
            /// 子单状态（1-待发货；2-已发货；31-已退款）
            /// </summary>
            [JsonPropertyName("sub_order_status")]
            public int? SubOrderStatus { get; set; }

            /// <summary>
            /// 收件地区县
            /// </summary>
            [JsonPropertyName("town")]
            public string? Town { get; set; }

            /// <summary>
            /// 区县编码
            /// </summary>
            [JsonPropertyName("town_id")]
            public int? TownId { get; set; }

            /// <summary>
            /// 子单快递运单号
            /// </summary>
            [JsonPropertyName("tracking_number")]
            public string? TrackingNumber { get; set; }

            public partial class GoodsEntryListResponse
            {

                /// <summary>
                /// 词条名称
                /// </summary>
                [JsonPropertyName("name")]
                public string? Name { get; set; }


            }

        }
        public partial class ItemListResponse
        {

            /// <summary>
            /// 商品数量
            /// </summary>
            [JsonPropertyName("goods_count")]
            public int? GoodsCount { get; set; }

            /// <summary>
            /// 商品编号
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品图片
            /// </summary>
            [JsonPropertyName("goods_img")]
            public string? GoodsImg { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string? GoodsName { get; set; }

            /// <summary>
            /// 商品销售价格
            /// </summary>
            [JsonPropertyName("goods_price")]
            public double? GoodsPrice { get; set; }

            /// <summary>
            /// 商品规格，使用（规格值1,规格值2）组合作为sku的表示，中间以英文逗号隔开
            /// </summary>
            [JsonPropertyName("goods_spec")]
            public string? GoodsSpec { get; set; }

            /// <summary>
            /// 商家外部编码（商品），注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
            /// </summary>
            [JsonPropertyName("outer_goods_id")]
            public string? OuterGoodsId { get; set; }

            /// <summary>
            /// 商家外部sku编码
            /// </summary>
            [JsonPropertyName("outer_id")]
            public string? OuterId { get; set; }

            /// <summary>
            /// 商品规格编码
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long? SkuId { get; set; }


        }

    }

}

