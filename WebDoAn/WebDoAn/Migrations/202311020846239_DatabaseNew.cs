namespace WebDoAn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adv", "CreatedBy", c => c.String());
            AddColumn("dbo.Adv", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Adv", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Adv", "ModifiedBy", c => c.String());
            AddColumn("dbo.Category", "CreatedBy", c => c.String());
            AddColumn("dbo.Category", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Category", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Category", "ModifiedBy", c => c.String());
            AddColumn("dbo.New", "CreatedBy", c => c.String());
            AddColumn("dbo.New", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.New", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.New", "ModifiedBy", c => c.String());
            AddColumn("dbo.Post", "CreatedBy", c => c.String());
            AddColumn("dbo.Post", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Post", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Post", "ModifiedBy", c => c.String());
            AddColumn("dbo.Contact", "CreatedBy", c => c.String());
            AddColumn("dbo.Contact", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contact", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contact", "ModifiedBy", c => c.String());
            AddColumn("dbo.Order", "CreatedBy", c => c.String());
            AddColumn("dbo.Order", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Order", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Order", "ModifiedBy", c => c.String());
            AddColumn("dbo.Product", "CreatedBy", c => c.String());
            AddColumn("dbo.Product", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Product", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Product", "ModifiedBy", c => c.String());
            AddColumn("dbo.ProductCategory", "CreatedBy", c => c.String());
            AddColumn("dbo.ProductCategory", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProductCategory", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProductCategory", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductCategory", "ModifiedBy");
            DropColumn("dbo.ProductCategory", "ModifiedDate");
            DropColumn("dbo.ProductCategory", "CreatedDate");
            DropColumn("dbo.ProductCategory", "CreatedBy");
            DropColumn("dbo.Product", "ModifiedBy");
            DropColumn("dbo.Product", "ModifiedDate");
            DropColumn("dbo.Product", "CreatedDate");
            DropColumn("dbo.Product", "CreatedBy");
            DropColumn("dbo.Order", "ModifiedBy");
            DropColumn("dbo.Order", "ModifiedDate");
            DropColumn("dbo.Order", "CreatedDate");
            DropColumn("dbo.Order", "CreatedBy");
            DropColumn("dbo.Contact", "ModifiedBy");
            DropColumn("dbo.Contact", "ModifiedDate");
            DropColumn("dbo.Contact", "CreatedDate");
            DropColumn("dbo.Contact", "CreatedBy");
            DropColumn("dbo.Post", "ModifiedBy");
            DropColumn("dbo.Post", "ModifiedDate");
            DropColumn("dbo.Post", "CreatedDate");
            DropColumn("dbo.Post", "CreatedBy");
            DropColumn("dbo.New", "ModifiedBy");
            DropColumn("dbo.New", "ModifiedDate");
            DropColumn("dbo.New", "CreatedDate");
            DropColumn("dbo.New", "CreatedBy");
            DropColumn("dbo.Category", "ModifiedBy");
            DropColumn("dbo.Category", "ModifiedDate");
            DropColumn("dbo.Category", "CreatedDate");
            DropColumn("dbo.Category", "CreatedBy");
            DropColumn("dbo.Adv", "ModifiedBy");
            DropColumn("dbo.Adv", "ModifiedDate");
            DropColumn("dbo.Adv", "CreatedDate");
            DropColumn("dbo.Adv", "CreatedBy");
        }
    }
}
