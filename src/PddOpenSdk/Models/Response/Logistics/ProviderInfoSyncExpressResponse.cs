namespace PddOpenSdk.Models.Response.Logistics;
public partial class ProviderInfoSyncExpressResponse
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("error_msg")]
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }


}

