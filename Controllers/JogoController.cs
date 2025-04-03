using Api_Jogos_Isaac.Domains;
using Api_Jogos_Isaac.Interfaces;
using Api_Jogos_Isaac.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Jogos_Isaac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogoController : ControllerBase
    {
        private readonly IJogosRepository _jogosRepository;
        public JogoController(IJogosRepository jogosRepository)
        {
            _jogosRepository = jogosRepository;
        }

        [HttpPost]
        public IActionResult Post(Jogos jogo)
        {
            try
            {
                _jogosRepository.Cadastrar(jogo);

                return StatusCode(201, jogo);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
    }
}

