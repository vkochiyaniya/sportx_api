using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace sportx_api.Models;

public partial class Chat
{
    public int ChatId { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    [JsonIgnore]
    public virtual User? User { get; set; }
}
