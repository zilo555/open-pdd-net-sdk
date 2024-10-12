namespace PddOpenSdk.Models.Response.Refund;
public partial class UpdateNextoneLogisticsWarehouseResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// after_sales_id
            /// </summary>
            [JsonPropertyName("after_sales_id")]
            public long? AfterSalesId { get; set; }

            /// <summary>
            /// order_sn
            /// </summary>
            [JsonPropertyName("order_sn")]
            public string OrderSn { get; set; }


        }

    }

}

