namespace TriviaDb.DataAccess.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using TriviaDb.DataAccess.ExtentionMethods;

    [Table("QuestionAnswers")]
    public class QuestionAnswers
    {
        [Column("id")]
        [Key]
        [Required]
        public int Id { get; set; }
        [NotMapped]
        public Guid RandomOrder
        {
            get
            {
                return Guid.NewGuid();
            }
        }

        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        [NotMapped]
        public List<string> incorrect_answers { get { return incorrect_answers_string.Split(',').ToList(); } }
        public string incorrect_answers_string 
        {get; set;}


    }

}
