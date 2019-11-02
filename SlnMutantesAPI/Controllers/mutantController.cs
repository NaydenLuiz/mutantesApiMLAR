using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlnMutantesAPI.Models;

namespace SlnMutantesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class mutantController : ControllerBase
    {
        public mutantController(ILogger<mutantController> logger)
        {
            _logger = logger;
        }
        // GET: mutant
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        private readonly ILogger<mutantController> _logger;

        // GET: mutant/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: mutant
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: mutant/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        public bool Insert()
        {
            try
            {
                using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<ADN>("ADN");

                    // Create your new customer instance
                    var adn = new ADN
                    {
                        Id = Guid.NewGuid().ToString(),
                        DateTime = DateTime.Now,
                        DNA = "",
                        Human = true,
                        Multant = false

                    };

                    // Insert new customer document (Id will be auto-incremented)
                    col.Insert(adn);


                    // Use LINQ to query documents
                    var results = col.Find(x => x.Human ==true);

                    

                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }
        }
    }
}
