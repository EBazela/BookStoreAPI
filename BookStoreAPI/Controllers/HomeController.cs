using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService logger;

        public HomeController(ILoggerService logger)
        {
            this.logger = logger;
        }
        /// <summary>
        /// Get Values
        /// </summary>
        /// <returns></returns>
        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInfo("Accessed Home Controller");
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// Get Value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            logger.LogDebug("Get a Value");
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            logger.LogError("This is an error");
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            logger.LogWarn("This is warning");
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
