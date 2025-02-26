namespace PddOpenSdk.Models;

public class SocketMessageModel
{
    [JsonPropertyName("id")]
    public long Id { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    [JsonPropertyName("commandType")]
    public CommandType CommandType { get; set; }
    [JsonPropertyName("time")]
    public long Time { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    [JsonPropertyName("message")]
    public Message? Message { get; set; }
    [JsonPropertyName("sendTime")]
    public long SendTime { get; set; }

    public SocketMessageModel(CommandType commandType)
    {
        CommandType = commandType;
    }
}

public enum CommandType
{
    HeartBeat, Ack, Fail, Common,
}
public class Message
{
    /**  
     * 消息类型  
     */
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    /**  
     * 商户ID  
     */
    [JsonPropertyName("mallID")]
    public long MallID { get; set; }
    /**  
     * 消息属性内容  
     */
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
public class AckMessage
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
    [JsonPropertyName("commandType")]
    public CommandType CommandType { get; set; }
    [JsonPropertyName("time")]
    public long Time { get; set; }
    [JsonPropertyName("sendTime")]
    public long SendTime { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    [JsonPropertyName("mallID")]
    public long MallId { get; set; }
}
