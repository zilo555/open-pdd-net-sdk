namespace PddOpenSdk.Models.Response.LogisticsCompany;
public partial class UploadLogisticsTicketImageResponse
{

    /// <summary>
    /// 返回response
    /// </summary>
    [JsonPropertyName("logistics_ticket_image_upload_response")]
    public LogisticsTicketImageUploadResponseResponse LogisticsTicketImageUploadResponse { get; set; }

    public partial class LogisticsTicketImageUploadResponseResponse
    {

        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }


    }

}

