namespace CodeFirst.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String());
            DropColumn("dbo.Courses", "Title");

            //should be:
            // AddColumn("dbo.Courses", "Name", c => c.String(nullable: false)); 
            //Sql("UPDATE Courses SET Name = "Title");     **Prevent lose of data by copying data to new column
            //DropColumn("dbo.Courses", "Title");
        }

        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "Name");

            //should be:
            // AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            //Sql("UPDATE Courses SET Title = Name");
            //DropColumn("dbo.Courses", "Name");
        }
    }
}
