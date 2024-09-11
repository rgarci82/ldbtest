using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Firstname required { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
    }
}