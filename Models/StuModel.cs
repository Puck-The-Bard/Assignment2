using System;
using System.ComponentModel.DataAnnotations;

namespace ProgClub.Models
{
    public class Student
    {
        public int StuID {get; set;}
        public string FullName {get; set;}
        public string email {get; set;}
    }
} 