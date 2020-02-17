using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ProgClub.Models
{
    public class Group 
    {
        public int ID {get; set;}
        public string GroupName {get; set;}
        public string GroupDesc {get; set;}
        public List<Student> Students {get; set;}
    }
} 