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
            // retornando o aluno
            return new Aluno
            {
                Ru = 3781368,
                Nome = "Lucas Antonio Silva da Conceicao"
            };
        }

        // Entidade com as propriedades de um aluno
        public class Aluno
        {
            public int Ru { get; set; }
            public string? Nome { get; set; }
        }
    }
}