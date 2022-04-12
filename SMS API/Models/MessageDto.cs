using Newtonsoft.Json;

namespace SMS_API.Models;

public class MessageDto
{
    [JsonProperty("originatorId")] public string OriginatorId { get; set; } = "Samala";
    
    [JsonProperty("msisdn")] 
    public string Msisdn { get; set; }
    
    [JsonProperty("text")] 
    public string Text { get; set; }
}