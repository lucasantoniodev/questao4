using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace questao5.Controllers
{
    [ApiController]
    [Route("pitagoras")]
    public class PitagorasController : ControllerBase
    {
        [HttpGet]
        public object Get(int a, int b, int c)
        {
            // Calculando as potências
            var a2 = Math.Pow(a, 2);
            var b2 = Math.Pow(b, 2);
            var c2 = Math.Pow(c, 2);

            // Retorna um objeto
            // Retorna true ou false se c2 for igual ao somatório de a2 + b2
            return new
            {
                formula = "c² = a² + b²",
                equacao = $"{c2} = {a2} + {b2}",
                isEqual = c2 == a2 + b2
            };
        }
    }
}
