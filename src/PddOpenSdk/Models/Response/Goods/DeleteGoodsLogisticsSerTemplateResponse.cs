namespace PddOpenSdk.Models.Response.Goods;
public partial class DeleteGoodsLogisticsSerTemplateResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_logistics_ser_template_delete_response")]
    public GoodsLogisticsSerTemplateDeleteResponseResponse GoodsLogisticsSerTemplateDeleteResponse { get; set; }

    public partial class GoodsLogisticsSerTemplateDeleteResponseResponse
    {

        /// <summary>
        /// is_success
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

