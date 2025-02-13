namespace PddOpenSdk.Models.Response.Logistics;
public partial class EnterConsoWarehousePackScanResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse? Response { get; set; }

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
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public ResultResponse? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// 是否属于集运包裹
            /// </summary>
            [JsonPropertyName("is_jiyun_pack")]
            public bool? IsJiyunPack { get; set; }

            /// <summary>
            /// 大库区
            /// </summary>
            [JsonPropertyName("major_position_area")]
            public string? MajorPositionArea { get; set; }

            /// <summary>
            /// 小库区
            /// </summary>
            [JsonPropertyName("minor_position_area")]
            public string? MinorPositionArea { get; set; }

            /// <summary>
            /// 包裹入库扫描结果：1-需上架；2-单包裹；3-需拒收；4-异常包裹
            /// </summary>
            [JsonPropertyName("pack_scan_enter_result")]
            public int? PackScanEnterResult { get; set; }

            /// <summary>
            /// 库位码
            /// </summary>
            [JsonPropertyName("position_code")]
            public string? PositionCode { get; set; }

            /// <summary>
            /// 标签码。1-需上架；2-单包裹；3-无主件；4-非本仓；5-拒收；6-其它；
            /// </summary>
            [JsonPropertyName("print_label_code")]
            public int? PrintLabelCode { get; set; }


        }

    }

}

