using CarLib.model;
using CarRest.Managers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static CarManager mgr = new CarManager();

        // GET: api/<CarsController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return mgr.GetAll();
        }

        // GET api/<CarsController>/5
        [HttpGet("{regNo}")]
        public Car Get(String regNo)
        {
            return mgr.GetOne(regNo);
        }

        // POST api/<CarsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]

        public IActionResult Post([FromBody] CarDTO car)
        {
            try
            {
                Car newCar = new Car(car);
                Car addedCar = mgr.Add(newCar);
                return Created($"Cars/{addedCar.RegNo}", addedCar);
            }
            catch (ArgumentNullException ane)
            {
                return BadRequest(ane.Message);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        
        // DELETE api/<CarsController>/5
        [HttpDelete("{regNo}")]
        public Car Delete(String regNo)
        {
            return mgr.Delete(regNo);
        }
    }
}
