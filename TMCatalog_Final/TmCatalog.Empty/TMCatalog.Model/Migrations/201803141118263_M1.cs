namespace TMCatalog.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderEntries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_ID)
                .Index(t => t.ArticleId)
                .Index(t => t.Order_ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                        OrderState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderEntries", "Order_ID", "dbo.Orders");
            DropForeignKey("dbo.OrderEntries", "ArticleId", "dbo.Articles");
            DropIndex("dbo.OrderEntries", new[] { "Order_ID" });
            DropIndex("dbo.OrderEntries", new[] { "ArticleId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderEntries");
        }
    }
}
