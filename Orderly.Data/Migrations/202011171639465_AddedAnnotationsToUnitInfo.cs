﻿namespace Orderly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotationsToUnitInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnitInfo", "LossDate", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UnitInfo", "LossDate");
        }
    }
}
