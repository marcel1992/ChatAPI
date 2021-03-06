﻿using System;

namespace Chat.RequestDTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsOnline { get; set; }
    }
}
