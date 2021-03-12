namespace TriviaDb.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using TriviaDb.DataAccess.Models;

    public class TriviaDbContext : DbContext
    {
        public TriviaDbContext(DbContextOptions<TriviaDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<QuestionAnswers> QuestionAnswers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Configure domain classes using modelBuilder here
        //    // Categories
        //    var jsonString = File.ReadAllText("Category.json");
        //    var categories = JsonConvert.DeserializeObject<IList<Category>>(jsonString);
        //    modelBuilder.Entity<Category>().HasData(categories);

        //    jsonString = File.ReadAllText("QuestionAnswers.json");
        //    var qna = JsonConvert.DeserializeObject<AnswersOutput>(jsonString);
        //    modelBuilder.Entity<QuestionAnswers>().HasData(qna.results);

        //}
    }
}
