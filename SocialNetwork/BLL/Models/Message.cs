﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string SenderEmail { get; set; }
        public string RecipientEmail { get; set; }

        public Message(
            int id, 
            string content, 
            string senderEmail, 
            string recipientEmail)
        {
            this.Id = id;
            this.Content = content;
            this.SenderEmail = senderEmail;
            this.RecipientEmail = recipientEmail;
        }
    }
}
