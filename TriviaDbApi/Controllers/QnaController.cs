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
        public async Task<AnswersOutput> Index(string category, string difficulty, string type, int amount = 10)
        {
            if (amount > 50)
            {
                amount = 50;
            }
            var categoryArray = category?.Split(',').Select(Int32.Parse).ToList();

            var ops = await db.QuestionAnswers.Where(x => true).ToListAsync();
            IEnumerable<QuestionAnswers> op;
            if(category.Length > 0)
            {
                var categoryNames = db.Categories.Where(x => categoryArray.Contains(x.Id))?.Select(x => x.Name).ToList(); 
                op = ops.Where(x => categoryNames.Contains(x.category));
            }
            else
            {
                op = ops;
            }

            if (!string.IsNullOrEmpty(difficulty) && difficulty!= "0")
            {
                op = op.Where(x => x.difficulty == difficulty);
            }

            if (!string.IsNullOrEmpty(type) && type != "0")
            {
                op = op.Where(x => x.type == type);
            }
            var myGuid = Guid.NewGuid();
            var results =  op.OrderBy(r => r.RandomOrder).Take(amount).ToList();

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
