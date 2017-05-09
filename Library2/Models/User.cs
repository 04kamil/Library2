using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string Login { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Active { get; set; }
        public int AccountType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}