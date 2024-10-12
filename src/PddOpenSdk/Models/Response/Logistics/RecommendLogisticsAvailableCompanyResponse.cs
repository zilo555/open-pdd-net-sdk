namespace PddOpenSdk.Models.Response.Logistics;
public partial class RecommendLogisticsAvailableCompanyResponse
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
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        public partial class ResultResponse
        {

            /// <summary>
            /// 收件人市id
            /// </summary>
            [JsonPropertyName("city_id")]
            public long? CityId { get; set; }

            /// <summary>
            /// 快递公司id
            /// </summary>
            [JsonPropertyName("company_id")]
            public List<long?> CompanyId { get; set; }


        }

    }

}

