using Microsoft.AspNetCore.Mvc;
using net_core.Models;
using System.Collections.Immutable;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Instructors : ControllerBase
    {
        // GET: api/<Instructors>
        [HttpGet]
        public IEnumerable<Instructor> Get()
        {
            return Data.Instructors;
        }

        // GET api/<Instructors>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Instructors>
        [HttpPost]
        public ActionResult<Instructor> Post([FromBody] Instructor newinstructor)
        {
            if (newinstructor == null)
                return BadRequest("עובד לא יכול להיות null");
            newinstructor.Id =Data.Instructors.Max(i => i.Id)+1;
           Data.Instructors.Add(newinstructor);
            return CreatedAtAction(nameof(Get), new { id = newinstructor.Id }, newinstructor);
        }

        // PUT api/<Instructors>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  Instructor updatedInstructor)
        {
            if(updatedInstructor == null||updatedInstructor.Id!=id)
            {
                return BadRequest("Invalid instructor ");
            }
           Instructor existingInstructor=Data.Instructors.FirstOrDefault(i=>i.Id==id);
            if(existingInstructor == null)
                return BadRequest("Instructor not found");
            existingInstructor.Name=updatedInstructor.Name;
            existingInstructor.Age=updatedInstructor.Age;
            existingInstructor.Experience=updatedInstructor.Experience;
            existingInstructor.Specialty=updatedInstructor.Specialty;
            existingInstructor.Phone=updatedInstructor.Phone;


            return NoContent();



        }

        // DELETE api/<Instructors>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Instructor existingInstructor = Data.Instructors.FirstOrDefault(i => i.Id == id);

            if (existingInstructor == null)
            {
                return NotFound("Swimmer not found");
            }


            Data.Instructors.Remove(existingInstructor);

            return NoContent();
        }
    }
}
