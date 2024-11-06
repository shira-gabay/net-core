using Microsoft.AspNetCore.Mvc;
using net_core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Swimmers : ControllerBase
    {
        

        // GET: api/<Swimmers>
        [HttpGet]
        public static IEnumerable<Swimmer> Get()
        {
            return Data.Swimmers; // החזרת רשימת השחיינים
        }

        // GET api/<Swimmers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Swimmers>
        [HttpPost]
        public ActionResult<Swimmer> Post([FromBody] Swimmer newSwimmer)

        {
            if (newSwimmer==null)
                return BadRequest("שחיין לא יכול להיות null");
            newSwimmer.Id =Data.Swimmers.Max(i=>i.Id)+1;
            Data.Swimmers.Add(newSwimmer);
            return CreatedAtAction(nameof(Get), new { id = newSwimmer.Id }, newSwimmer);
            
        }

        // PUT api/<Swimmers>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Swimmer updatedSwimmer)
        {
            if (updatedSwimmer == null || updatedSwimmer.Id != id)
            {
                return BadRequest("Invalid swimmer ");
            }

            
            Swimmer existingSwimmer = Data.Swimmers.FirstOrDefault(s => s.Id == id);

            if (existingSwimmer == null)
            {
                return NotFound("Swimmer not found.");  
            }

            
            existingSwimmer.Name = updatedSwimmer.Name;
            existingSwimmer.Age = updatedSwimmer.Age;
            existingSwimmer.Level = updatedSwimmer.Level;
            existingSwimmer.Email = updatedSwimmer.Email;
            existingSwimmer.Phone = updatedSwimmer.Phone;

            return NoContent();
        }

        // DELETE api/<Swimmers>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            Swimmer existingSwimmer = Data.Swimmers.FirstOrDefault(s => s.Id == id);

            if (existingSwimmer == null)
            {
                return NotFound("Swimmer not found.");  
            }

            
            Data.Swimmers.Remove(existingSwimmer);

            return NoContent();
        }
    }
}
