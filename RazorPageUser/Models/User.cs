using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPageUser.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Password { get; set; }
    }
}
