namespace TriviaDbApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using TriviaDb.DataAccess;
    using TriviaDb.DataAccess.Models;

    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private readonly TriviaDbContext db;
        public HttpClient Client { get; }

        public CategoryController(TriviaDbContext db, HttpClient client)
        {
            this.db = db;
            Client = client;
        }

        [HttpGet]
        public async Task<IList<Category>> Index()
        {
           
            return await db.Categories.ToListAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Category> Index(int id)
        {
            //int i = 0;
            //while (i < 10000)
            //{
            //    var str = await Client.GetStringAsync("https://opentdb.com/api.php?amount=50");
            //    var op = JsonConvert.DeserializeObject<AnswersOutput>(str);
            //    foreach (var record in op.results)
            //    {
            //        if (!db.QuestionAnswers.Any(x => x.Id == record.Id))
            //        {
            //            db.QuestionAnswers.Add(record);
            //            db.SaveChanges();
            //        }
            //    }

            //}

            return await db.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
