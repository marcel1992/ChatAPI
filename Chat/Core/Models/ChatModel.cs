using System;

namespace Chat.Core.Models
{
    public class ChatModel
    {
        public int Id { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }
        public bool IsOnline { get; set; }
    }
}
