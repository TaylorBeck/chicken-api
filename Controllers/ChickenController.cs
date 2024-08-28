using Microsoft.AspNetCore.Mvc;
using ChickenAPI.Models;

namespace ChickenAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChickenController : ControllerBase
    {
        private static List<Chicken> _chickens = new List<Chicken>();

        [HttpGet]
        public ActionResult<IEnumerable<Chicken>> Get()
        {
            return Ok(_chickens);
        }

        [HttpPost]
        public ActionResult<Chicken> Post(Chicken chicken)
        {
            chicken.Id = _chickens.Count + 1;
            _chickens.Add(chicken);
            return CreatedAtAction(nameof(Get), new { id = chicken.Id }, chicken);
        }
    }
}