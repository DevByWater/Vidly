namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingGenresModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.s", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.s", new[] { "Genre_Id" });
            AlterColumn("dbo.s", "Genre_Id", c => c.Int());
            CreateIndex("dbo.s", "Genre_Id");
            AddForeignKey("dbo.s", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.s", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.s", new[] { "Genre_Id" });
            AlterColumn("dbo.s", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.s", "Genre_Id");
            AddForeignKey("dbo.s", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
