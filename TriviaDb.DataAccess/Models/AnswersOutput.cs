namespace TriviaDb.DataAccess.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class AnswersOutput
    {
        public int response_code { get { return this.results != null && this.results.Any() ? 0 : 1; } }
        public List<QuestionAnswers> results { get; set; }

    }
}
