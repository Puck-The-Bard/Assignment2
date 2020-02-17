using System;
using System.ComponentModel.DataAnnotations;

namespace ProgClub.Models
{
    public class Project
    {
        public int ProjectID {get; set;}
        public string ProjectName {get; set;}
        public Client Client {get; set;}
    }
} 