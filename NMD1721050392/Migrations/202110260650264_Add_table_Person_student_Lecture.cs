namespace NMD1721050392.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_table_Person_student_Lecture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128, unicode: false),
                        PersonName = c.String(unicode: false),
                        Faculty = c.String(),
                        Department = c.String(),
                        University = c.String(),
                        Address = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
