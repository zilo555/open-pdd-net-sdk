namespace PddOpenSdk.Models.Response.Goods;
public partial class SetGoodsSaleStatusResponse
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("goods_sale_status_set_response")]
    public GoodsSaleStatusSetResponseResponse? GoodsSaleStatusSetResponse { get; set; }

    public partial class GoodsSaleStatusSetResponseResponse
    {

        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("is_success")]
        public bool? IsSuccess { get; set; }


    }

}

