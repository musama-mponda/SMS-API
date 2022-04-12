using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SMS_API.Entities;

public class Messages
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; } = null!;

    [JsonPropertyName("originatorId")]
    public string OriginatorId { get; set; } = null!;

    [JsonPropertyName("msisdn")]
    public string Msisdn { get; set; } = null!;
    
    [JsonPropertyName("createdAt")]
    public DateTime CreateAt { get; set; } = DateTime.Now;

    [JsonPropertyName("delivered")]
    public bool Delivered { get; set; } = true;
}