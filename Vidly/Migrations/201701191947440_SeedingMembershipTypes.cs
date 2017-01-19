namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MembershipTypes ON");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DiscountRate, DurationInMonths) VALUES  (1, 'Free', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DiscountRate, DurationInMonths) VALUES (2, 'Monthly', 30, 10, 1)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DiscountRate, DurationInMonths) VALUES (3, 'Quarterly', 90, 15, 3)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DiscountRate, DurationInMonths) VALUES (4, 'Annual', 300, 25, 12)");
            Sql("SET IDENTITY_INSERT MembershipTypes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
