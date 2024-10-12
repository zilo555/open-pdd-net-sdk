namespace PddOpenSdk.Models.Response.Refund;
public partial class AgreeRefundReturngoodsResponse
{

    /// <summary>
    /// 返回结果
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 接口调用错误编码
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 接口调用错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 返回内容
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 接口是否调用成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// 售后id
            /// </summary>
            [JsonPropertyName("after_sales_id")]
            public long? AfterSalesId { get; set; }

            /// <summary>
            /// 退货是否成功描述
            /// </summary>
            [JsonPropertyName("message")]
            public string Message { get; set; }

            /// <summary>
            /// 订单号
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }

            /// <summary>
            /// 退货是否成功
            /// </summary>
            [JsonPropertyName("success")]
            public bool? Success { get; set; }


        }

    }

}

