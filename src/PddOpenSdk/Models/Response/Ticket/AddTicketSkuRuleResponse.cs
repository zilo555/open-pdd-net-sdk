namespace PddOpenSdk.Models.Response.Ticket;
public partial class AddTicketSkuRuleResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }

    public partial class ResponseResponse
    {

        /// <summary>
        /// 规则 ID
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonPropertyName("rule_version")]
        public string RuleVersion { get; set; }


    }

}

