using Microsoft.AspNetCore.Mvc;
using net_core.Models;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Activities : ControllerBase
    {
        // GET: api/<Activities>
        [HttpGet]
        public IEnumerable<Activity> Get()
        {
            return Data.Activities;
        }

        // GET api/<Activities>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Activities>
        [HttpPost]
        public ActionResult <Activity> Post([FromBody]  Activity newActivity)
        {
            if(newActivity == null)
            {
                return BadRequest("הפעילות לא יכולה להיות null");
            }
            newActivity.Id=Data.Activities.Max(i=>i.Id)+1;
            Data.Activities.Add(newActivity);
            return CreatedAtAction(nameof(Get), new { id = newActivity.Id }, newActivity);

        }

        // PUT api/<Activities>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Activity updatedActivity)
        {
            if (updatedActivity == null || updatedActivity.Id != id)
            {
                return BadRequest("Invalid activity ");
            }

            Activity existingActivity = Data.Activities.FirstOrDefault(a => a.Id == id);
            if (existingActivity == null)
            {
                return NotFound("Activity not found.");
            }

            // עדכון השדות של הפעילות הקיימת
            existingActivity.Name = updatedActivity.Name;
            existingActivity.Date = updatedActivity.Date;
            existingActivity.Instructor = updatedActivity.Instructor;
            existingActivity.Level = updatedActivity.Level;
            existingActivity.MaxParticipants = updatedActivity.MaxParticipants;

            return NoContent();
        }

        // DELETE api/<Activities>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Activity existingActivity=Data.Activities.FirstOrDefault(a=>a.Id == id);
            if (existingActivity == null)
            {
                return NotFound("Activities not found");
            }
            Data.Activities.Remove(existingActivity);
            return NoContent();


        }
    }
}
