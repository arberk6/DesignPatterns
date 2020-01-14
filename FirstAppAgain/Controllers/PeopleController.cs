using FirstAppAgain.Models;
using FirstAppAgain.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppAgain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService context;

        public PeopleController(IPeopleService context)
        {
            this.context = context;
        }

        // GET: api/People
        [HttpGet]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
            return await context.GetAllPersons();
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
            var person = await context.GetPerson(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> PutPerson(int id, Person person)
        {

            if (id != person.PersonId)
            {
                return BadRequest();
            }


            var res = true;

            try
            {
                res = await context.Update(id, person);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/People/create
        [HttpPost("Create")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult> PostPerson([FromBody]JObject json)
        {
            string test = json.ToString();
            Person person = JsonConvert.DeserializeObject<Person>(json.ToString());
            string userType = json["TypeName"].ToString();

            var res = false;

            try
            {
                res = await context.Create(person, userType);
            }
            catch (DbUpdateException)
            {

                throw;

            }
            if (res)
            {
                return Conflict();
            }

            return Ok();
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        [EnableCors("AllowOrigin")]
        public async Task<ActionResult<bool>> DeletePerson(int id)
        {
            var res = await context.Delete(id);

            if (!res)
            {
                return NotFound();
            }

            return true;
        }
    }
}
