namespace DomofondRG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrate23052019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        AdsTypeId = c.Int(nullable: false),
                        ObjectTypeId = c.Int(nullable: false),
                        RoomsTypeId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        StatusTypeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        PhotoId = c.Int(nullable: false),
                        FavoriteId = c.Int(),
                        DatePublication = c.DateTime(nullable: false),
                        DateUpdatePublication = c.DateTime(),
                        Favorite_Id = c.Int(),
                        Photo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdsTypes", t => t.AdsTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Favorites", t => t.Favorite_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Favorites", t => t.FavoriteId)
                .ForeignKey("dbo.ObjectsTypes", t => t.ObjectTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Photos", t => t.Photo_Id)
                .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
                .ForeignKey("dbo.RoomsTypes", t => t.RoomsTypeId, cascadeDelete: true)
                .ForeignKey("dbo.StatusTypes", t => t.StatusTypeId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.CityId)
                .Index(t => t.AdsTypeId)
                .Index(t => t.ObjectTypeId)
                .Index(t => t.RoomsTypeId)
                .Index(t => t.StatusTypeId)
                .Index(t => t.UserId)
                .Index(t => t.PhotoId)
                .Index(t => t.FavoriteId)
                .Index(t => t.Favorite_Id)
                .Index(t => t.Photo_Id);
            
            CreateTable(
                "dbo.AdsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdsTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AdsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ads", t => t.AdsId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AdsId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ObjectsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ObjectsTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        RelativePath = c.String(),
                        AbsolutePath = c.String(),
                        AdsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ads", t => t.AdsId, cascadeDelete: true)
                .Index(t => t.AdsId);
            
            CreateTable(
                "dbo.RoomsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomsTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ads", "StatusTypeId", "dbo.StatusTypes");
            DropForeignKey("dbo.Ads", "RoomsTypeId", "dbo.RoomsTypes");
            DropForeignKey("dbo.Ads", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.Ads", "Photo_Id", "dbo.Photos");
            DropForeignKey("dbo.Photos", "AdsId", "dbo.Ads");
            DropForeignKey("dbo.Ads", "ObjectTypeId", "dbo.ObjectsTypes");
            DropForeignKey("dbo.Ads", "FavoriteId", "dbo.Favorites");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Favorites", "UserId", "dbo.Users");
            DropForeignKey("dbo.Ads", "UserId", "dbo.Users");
            DropForeignKey("dbo.Ads", "Favorite_Id", "dbo.Favorites");
            DropForeignKey("dbo.Favorites", "AdsId", "dbo.Ads");
            DropForeignKey("dbo.Cities", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Ads", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Ads", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Ads", "AdsTypeId", "dbo.AdsTypes");
            DropIndex("dbo.Photos", new[] { "AdsId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Favorites", new[] { "AdsId" });
            DropIndex("dbo.Favorites", new[] { "UserId" });
            DropIndex("dbo.Cities", new[] { "RegionId" });
            DropIndex("dbo.Ads", new[] { "Photo_Id" });
            DropIndex("dbo.Ads", new[] { "Favorite_Id" });
            DropIndex("dbo.Ads", new[] { "FavoriteId" });
            DropIndex("dbo.Ads", new[] { "PhotoId" });
            DropIndex("dbo.Ads", new[] { "UserId" });
            DropIndex("dbo.Ads", new[] { "StatusTypeId" });
            DropIndex("dbo.Ads", new[] { "RoomsTypeId" });
            DropIndex("dbo.Ads", new[] { "ObjectTypeId" });
            DropIndex("dbo.Ads", new[] { "AdsTypeId" });
            DropIndex("dbo.Ads", new[] { "CityId" });
            DropIndex("dbo.Ads", new[] { "RegionId" });
            DropTable("dbo.StatusTypes");
            DropTable("dbo.RoomsTypes");
            DropTable("dbo.Photos");
            DropTable("dbo.ObjectsTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Favorites");
            DropTable("dbo.Regions");
            DropTable("dbo.Cities");
            DropTable("dbo.AdsTypes");
            DropTable("dbo.Ads");
        }
    }
}
