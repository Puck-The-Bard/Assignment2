using System;
using System.ComponentModel.DataAnnotations;

namespace ProgClub.Models
{
    public class Client
    {
        public int ClientID {get; set;}
        public string ClientName {get; set;}
        public string Email {get; set;}
        public string Description {get; set;}
    }
} 