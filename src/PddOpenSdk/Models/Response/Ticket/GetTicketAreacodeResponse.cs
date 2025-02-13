namespace PddOpenSdk.Models.Response.Ticket;
public partial class GetTicketAreacodeResponse
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
        [JsonPropertyName("area_list")]
        public List<AreaListResponse?>? AreaList { get; set; }

        public partial class AreaListResponse
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("code")]
            public int? Code { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("level")]
            public int? Level { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonPropertyName("parent_code")]
            public int? ParentCode { get; set; }


        }

    }

}

