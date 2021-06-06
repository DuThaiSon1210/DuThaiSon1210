using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace thaison1210.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "UserName khong duoc de trong")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PassWord khong duoc de trong")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}