namespace Proceum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuizAttempts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quiz_Id = c.Int(nullable: false),
                        QuizType = c.String(maxLength: 2147483647),
                        QuizTitle = c.String(maxLength: 2147483647),
                        DurationInMinutes = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        UserAnswersJSON = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Instructions = c.String(maxLength: 2147483647),
                        Title = c.String(maxLength: 2147483647),
                        DurationInMinutes = c.Int(nullable: false),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuizQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quiz_Id = c.Int(nullable: false),
                        ChoicesJSON = c.String(maxLength: 2147483647),
                        CorrectAnswersJSON = c.String(maxLength: 2147483647),
                        QuestionRTF = c.String(maxLength: 2147483647),
                        AnswerType = c.Int(nullable: false),
                        OrderBy = c.Int(nullable: false),
                        CorrectMarks = c.Int(nullable: false),
                        IncorrectMarks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuizQuestions");
            DropTable("dbo.Quizs");
            DropTable("dbo.QuizAttempts");
        }
    }
}
