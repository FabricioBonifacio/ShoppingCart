namespace ShoppingCart.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Parcels = c.Int(nullable: false),
                        CreditCardNumber = c.String(),
                        ExpirationDate = c.String(),
                        CreditCardOwnerName = c.String(),
                        SecurityCode = c.String(),
                        Address = c.String(),
                        Complement = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        CartID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CartDate = c.DateTime(nullable: false),
                        Billing_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PaymentInformations", t => t.Billing_ID)
                .Index(t => t.Billing_ID);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        CartID = c.Int(nullable: false),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .ForeignKey("dbo.Carts", t => t.CartID, cascadeDelete: true)
                .Index(t => t.CartID)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "CartID", "dbo.Carts");
            DropForeignKey("dbo.CartItems", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Carts", "Billing_ID", "dbo.PaymentInformations");
            DropIndex("dbo.CartItems", new[] { "Product_ID" });
            DropIndex("dbo.CartItems", new[] { "CartID" });
            DropIndex("dbo.Carts", new[] { "Billing_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.CartItems");
            DropTable("dbo.Carts");
            DropTable("dbo.PaymentInformations");
        }
    }
}
