namespace TMCatalog.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderEntries", name: "Order_ID", newName: "OrderID");
            RenameIndex(table: "dbo.OrderEntries", name: "IX_Order_ID", newName: "IX_OrderID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.OrderEntries", name: "IX_OrderID", newName: "IX_Order_ID");
            RenameColumn(table: "dbo.OrderEntries", name: "OrderID", newName: "Order_ID");
        }
    }
}
