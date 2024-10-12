namespace PddOpenSdk.Models.Response.Util;
public partial class GetPopMallBindTicketResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// ticket
        /// </summary>
        [JsonPropertyName("ticket")]
        public string Ticket { get; set; }


    }

}

