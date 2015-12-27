using System.Web.Http;

namespace SimpleCalculator.Controllers
{
    public class CalculationController : ApiController
    {
        [HttpPost]
        public double Calculate([FromBody]string value)
        {
            return 0;
        }
    }
}