﻿namespace Vada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE membershipTypes SET name = 'Free' WHERE Id = 1"); 
            Sql("UPDATE membershipTypes SET name = 'Monthly' WHERE Id = 2"); 
            Sql("UPDATE membershipTypes SET name = 'Quarterly' WHERE Id = 3"); 
            Sql("UPDATE membershipTypes SET name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
