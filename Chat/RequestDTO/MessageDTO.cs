using System;

namespace Chat.RequestDTO
{
    public class MessageDTO
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsOnline { get; set; }
    }
}
