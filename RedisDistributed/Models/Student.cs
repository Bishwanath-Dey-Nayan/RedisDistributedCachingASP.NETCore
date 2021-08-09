using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDistributed.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string IDNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
