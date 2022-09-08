namespace Support.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShoppingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shoppings", t => t.ShoppingId, cascadeDelete: true)
                .Index(t => t.ShoppingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "ShoppingId", "dbo.Shoppings");
            DropIndex("dbo.Carts", new[] { "ShoppingId" });
            DropTable("dbo.Carts");
        }
    }
}
