namespace TriviaDbApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TriviaDb.DataAccess;
    using TriviaDb.DataAccess.Models;

    [ApiController]
    [Route("questions")]
    public class QnaController : ControllerBase
    {
        private readonly TriviaDbContext db;

        public QnaController(TriviaDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<AnswersOutput> Index(int category, string difficulty, string type, int amount = 10)
        {
            if (amount > 50)
            {
                amount = 50;
            }

            var op = db.QuestionAnswers.Where(x => true);
            if(category > 0)
            {
                var categoryName = db.Categories.FirstOrDefault(x => x.Id == category)?.Name; 
                op = op.Where(x => x.category == categoryName);
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                op = op.Where(x => x.difficulty == difficulty);
            }

            if (!string.IsNullOrEmpty(type))
            {
                op = op.Where(x => x.type == type);
            }

            var results =  await op.OrderBy(r => Guid.NewGuid()).Take(amount).ToListAsync();

            return new AnswersOutput { results = results };
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<QuestionAnswers> QuestionById(int id)
        {

            return await db.QuestionAnswers.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
