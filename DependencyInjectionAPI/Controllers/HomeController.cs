using DependencyInjectionAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRandomServices _randomNumber1;
        private readonly IRandomServices _randomNumber2;
        public HomeController(IRandomServices randomNumber1, IRandomServices randomNumber2)
        {
            _randomNumber1 = randomNumber1;
            _randomNumber2 = randomNumber2;
        }
        [HttpGet]
        public ActionResult ShowNumber()
        {
            return Ok(new
            {
                number1 = _randomNumber1.GetNum(),
                number2=_randomNumber2.GetNum()
            });
        }
    }
}
