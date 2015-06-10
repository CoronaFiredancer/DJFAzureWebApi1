namespace DJFAzureWebApi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstRegions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionId = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                    })
                .PrimaryKey(t => t.RegionId);
            
            CreateTable(
                "dbo.JKFs",
                c => new
                    {
                        JkfId = c.Int(nullable: false, identity: true),
                        Member_MemberId = c.Int(),
                        GreenCouncil_MemberId = c.Int(),
                        HunterCounsellor_MemberId = c.Int(),
                        Region_RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.JkfId)
                .ForeignKey("dbo.Members", t => t.Member_MemberId)
                .ForeignKey("dbo.Members", t => t.GreenCouncil_MemberId)
                .ForeignKey("dbo.Members", t => t.HunterCounsellor_MemberId)
                .ForeignKey("dbo.Regions", t => t.Region_RegionId)
                .Index(t => t.Member_MemberId)
                .Index(t => t.GreenCouncil_MemberId)
                .Index(t => t.HunterCounsellor_MemberId)
                .Index(t => t.Region_RegionId);
            
            CreateTable(
                "dbo.Associations",
                c => new
                    {
                        AssociationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Jkf_JkfId = c.Int(),
                    })
                .PrimaryKey(t => t.AssociationId)
                .ForeignKey("dbo.JKFs", t => t.Jkf_JkfId)
                .Index(t => t.Jkf_JkfId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        MemberNumber = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JKFs", "Region_RegionId", "dbo.Regions");
            DropForeignKey("dbo.JKFs", "HunterCounsellor_MemberId", "dbo.Members");
            DropForeignKey("dbo.JKFs", "GreenCouncil_MemberId", "dbo.Members");
            DropForeignKey("dbo.JKFs", "Member_MemberId", "dbo.Members");
            DropForeignKey("dbo.Associations", "Jkf_JkfId", "dbo.JKFs");
            DropIndex("dbo.Associations", new[] { "Jkf_JkfId" });
            DropIndex("dbo.JKFs", new[] { "Region_RegionId" });
            DropIndex("dbo.JKFs", new[] { "HunterCounsellor_MemberId" });
            DropIndex("dbo.JKFs", new[] { "GreenCouncil_MemberId" });
            DropIndex("dbo.JKFs", new[] { "Member_MemberId" });
            DropTable("dbo.Members");
            DropTable("dbo.Associations");
            DropTable("dbo.JKFs");
            DropTable("dbo.Regions");
        }
    }
}
