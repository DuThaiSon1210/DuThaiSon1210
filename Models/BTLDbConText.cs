using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace thaison1210.Models
{
    public partial class BTLDbConText : DbContext
    {
        public BTLDbConText()
            : base("name=BTLDbConText")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
