namespace PddOpenSdk.Models.Response.WayBill;
public partial class SettingCloudPrinterResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// 打印机设置修改结果
            /// </summary>
            [JsonPropertyName("cloud_printer_setting_result")]
            public bool? CloudPrinterSettingResult { get; set; }


        }

    }

}

