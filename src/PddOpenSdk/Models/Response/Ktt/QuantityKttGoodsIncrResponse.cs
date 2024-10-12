namespace PddOpenSdk.Models.Response.Ktt;
public partial class QuantityKttGoodsIncrResponse
{

    /// <summary>
    /// 结果
    /// </summary>
    [JsonPropertyName("ktt_goods_incr_quantity_response")]
    public KttGoodsIncrQuantityResponseResponse KttGoodsIncrQuantityResponse { get; set; }

    public partial class KttGoodsIncrQuantityResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }


    }

}

