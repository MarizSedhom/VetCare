namespace Support.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removColShopId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "ShoppingId", "dbo.Shoppings");
            DropIndex("dbo.Carts", new[] { "ShoppingId" });
            DropColumn("dbo.Carts", "ShoppingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "ShoppingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "ShoppingId");
            AddForeignKey("dbo.Carts", "ShoppingId", "dbo.Shoppings", "Id", cascadeDelete: true);
        }
    }
}
