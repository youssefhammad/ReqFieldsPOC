using Microsoft.AspNetCore.Mvc;
using ReqFieldsPOC.Model;
using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValidationController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Validation(RequiredCDA requiredCDA)
        {

            Validator validator = new Validator();

            var validationResult = validator.Validate(requiredCDA);

            return Ok(validationResult);
        }
    }
}