// <auto-generated />
namespace CodeFirst.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class RenameTitleToNameInCoursesTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(RenameTitleToNameInCoursesTable));
        
        string IMigrationMetadata.Id
        {
            get { return "201902150428457_RenameTitleToNameInCoursesTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}