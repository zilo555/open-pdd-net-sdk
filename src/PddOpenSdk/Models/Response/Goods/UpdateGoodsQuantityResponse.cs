namespace PddOpenSdk.Models.Response.Goods;
public partial class UpdateGoodsQuantityResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_quantity_update_response")]
    public GoodsQuantityUpdateResponseResponse? GoodsQuantityUpdateResponse { get; set; }

    public partial class GoodsQuantityUpdateResponseResponse
    {

        /// <summary>
        /// true
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

