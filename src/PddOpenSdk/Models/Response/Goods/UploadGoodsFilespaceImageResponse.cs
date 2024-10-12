namespace PddOpenSdk.Models.Response.Goods;
public partial class UploadGoodsFilespaceImageResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_filespace_image_upload_response")]
    public GoodsFilespaceImageUploadResponseResponse GoodsFilespaceImageUploadResponse { get; set; }

    public partial class GoodsFilespaceImageUploadResponseResponse
    {

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonPropertyName("file_id")]
        public long? FileId { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }


    }

}

