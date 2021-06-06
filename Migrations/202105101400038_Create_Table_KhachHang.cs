namespace thaison1210.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        IDKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKH = c.String(),
                    })
                .PrimaryKey(t => t.IDKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
