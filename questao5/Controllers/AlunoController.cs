using Microsoft.AspNetCore.Mvc;

namespace questao5.Controllers
{
    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {

        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Aluno Get()
        {
            return new Aluno
            {
                Ru = 3781368,
                Nome = "Lucas Antonio Silva da Conceicao"
            };
        }


        public class Aluno
        {
            public int Ru { get; set; }
            public string? Nome { get; set; }
        }
    }
}