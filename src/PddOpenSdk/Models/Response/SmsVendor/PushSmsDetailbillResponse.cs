namespace PddOpenSdk.Models.Response.SmsVendor;
public partial class PushSmsDetailbillResponse
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("sms_detailbill_push_resposne")]
    public SmsDetailbillPushResposneResponse? SmsDetailbillPushResposne { get; set; }

    public partial class SmsDetailbillPushResposneResponse
    {

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }


    }

}

