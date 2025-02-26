namespace PddOpenSdk;

public class ClientConfig
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string CallbackUrl { get; set; }
    public string AccessToken { get; set; } = string.Empty;
    /// <summary>
    /// 消息服务地址
    /// </summary>
    public string SocketUrl { get; set; } = string.Empty;
    /// <summary>
    /// socket 心跳间隔
    /// </summary>
    public int HeartBeatSeconds { get; set; } = 5;
}
