namespace PddOpenSdk.Models.Response.Util;
public partial class GetTimeResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("time_get_response")]
    public TimeGetResponseResponse TimeGetResponse { get; set; }

    public partial class TimeGetResponseResponse
    {

        /// <summary>
        /// 拼多多系统时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }


    }

}

