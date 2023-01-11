namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemQuantities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantity = c.Int(nullable: false),
                        item_id = c.Int(),
                        MaterialReceiving_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Items", t => t.item_id)
                .ForeignKey("dbo.MaterialReceivings", t => t.MaterialReceiving_id)
                .Index(t => t.item_id)
                .Index(t => t.MaterialReceiving_id);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        description = c.String(unicode: false),
                        price = c.Double(nullable: false),
                        unit_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Units", t => t.unit_id)
                .Index(t => t.unit_id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MaterialReceivings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        from = c.String(unicode: false),
                        date = c.DateTime(nullable: false, precision: 0),
                        approvedBy_id = c.Int(),
                        purchaser_id = c.Int(),
                        receivedBy_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.approvedBy_id)
                .ForeignKey("dbo.Users", t => t.purchaser_id)
                .ForeignKey("dbo.Users", t => t.receivedBy_id)
                .Index(t => t.approvedBy_id)
                .Index(t => t.purchaser_id)
                .Index(t => t.receivedBy_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        email = c.String(unicode: false),
                        password = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        description = c.String(unicode: false),
                        startDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterialReceivings", "receivedBy_id", "dbo.Users");
            DropForeignKey("dbo.MaterialReceivings", "purchaser_id", "dbo.Users");
            DropForeignKey("dbo.ItemQuantities", "MaterialReceiving_id", "dbo.MaterialReceivings");
            DropForeignKey("dbo.MaterialReceivings", "approvedBy_id", "dbo.Users");
            DropForeignKey("dbo.ItemQuantities", "item_id", "dbo.Items");
            DropForeignKey("dbo.Items", "unit_id", "dbo.Units");
            DropIndex("dbo.MaterialReceivings", new[] { "receivedBy_id" });
            DropIndex("dbo.MaterialReceivings", new[] { "purchaser_id" });
            DropIndex("dbo.MaterialReceivings", new[] { "approvedBy_id" });
            DropIndex("dbo.Items", new[] { "unit_id" });
            DropIndex("dbo.ItemQuantities", new[] { "MaterialReceiving_id" });
            DropIndex("dbo.ItemQuantities", new[] { "item_id" });
            DropTable("dbo.Projects");
            DropTable("dbo.Users");
            DropTable("dbo.MaterialReceivings");
            DropTable("dbo.Units");
            DropTable("dbo.Items");
            DropTable("dbo.ItemQuantities");
        }
    }
}
