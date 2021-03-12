namespace TriviaDb.DataAccess.Models
{
    using System.Collections.Generic;

    public class AnswersOutput
    {
        public int response_code { get; set; }
        public List<QuestionAnswers> results { get; set; }

    }
}
