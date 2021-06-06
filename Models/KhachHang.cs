using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace thaison1210.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public String IDKhachHang { get; set; }
        public String TenKH { get; set; }
    }
}