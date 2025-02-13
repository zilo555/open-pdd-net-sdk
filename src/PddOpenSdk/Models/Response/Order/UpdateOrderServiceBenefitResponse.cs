namespace PddOpenSdk.Models.Response.Order;
public partial class UpdateOrderServiceBenefitResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("service_benefit_update_response")]
    public ServiceBenefitUpdateResponseResponse? ServiceBenefitUpdateResponse { get; set; }

    public partial class ServiceBenefitUpdateResponseResponse
    {

        /// <summary>
        /// 更新成功:true；更新失败:false
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }


    }

}

