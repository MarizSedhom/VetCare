namespace Support.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "ShoppingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Carts", "ShoppingId");
            AddForeignKey("dbo.Carts", "ShoppingId", "dbo.Shoppings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "ShoppingId", "dbo.Shoppings");
            DropIndex("dbo.Carts", new[] { "ShoppingId" });
            DropColumn("dbo.Carts", "ShoppingId");
        }
    }
}
