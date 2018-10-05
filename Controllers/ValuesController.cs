using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class ValuesController : ControllerBase
    {
#pragma warning restore CS1591
        /// <summary>
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///<remarks>
        /// </remarks>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
