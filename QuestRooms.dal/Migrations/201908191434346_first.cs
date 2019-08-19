namespace QuestRooms.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressName = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        RoomDescription = c.String(),
                        RoomPassingTime = c.String(),
                        RoomMaxPlayers = c.Int(nullable: false),
                        RoomMinPlayers = c.Int(nullable: false),
                        RoomMinAgePlayers = c.Int(nullable: false),
                        Address = c.String(),
                        RoomPhoneNumber = c.String(),
                        RoomEmail = c.String(),
                        RoomCompany = c.String(),
                        RoomRating = c.String(),
                        RoomFearRating = c.Int(nullable: false),
                        RoomDifficultiesRating = c.Int(nullable: false),
                        RoomLogo = c.String(),
                        RoomGalary = c.String(),
                        Address_AddressID = c.Int(),
                        Street_StreetId = c.Int(),
                        Company_CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .ForeignKey("dbo.Streets", t => t.Street_StreetId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Street_StreetId)
                .Index(t => t.Company_CompanyId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.CityID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        StreetId = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        City_CityID = c.Int(),
                    })
                .PrimaryKey(t => t.StreetId)
                .ForeignKey("dbo.Cities", t => t.City_CityID)
                .Index(t => t.City_CityID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Rooms", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Streets", "City_CityID", "dbo.Cities");
            DropForeignKey("dbo.Rooms", "Street_StreetId", "dbo.Streets");
            DropForeignKey("dbo.Rooms", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Streets", new[] { "City_CityID" });
            DropIndex("dbo.Cities", new[] { "Country_CountryID" });
            DropIndex("dbo.Rooms", new[] { "Company_CompanyId" });
            DropIndex("dbo.Rooms", new[] { "Street_StreetId" });
            DropIndex("dbo.Rooms", new[] { "Address_AddressID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Companies");
            DropTable("dbo.Streets");
            DropTable("dbo.Cities");
            DropTable("dbo.Rooms");
            DropTable("dbo.Addresses");
        }
    }
}
