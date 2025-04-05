﻿using Api_Jogos_Isaac.Domains;
using Api_Jogos_Isaac.Interfaces;
using Api_Jogos_Isaac.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Jogos_Isaac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpPost] // metodo de cadastrar um Usuario por meio de post
        public IActionResult Post(Usuarios novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);
                return Created();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("BuscarPorId/{Id}")] // get de Buscar um Usuario atraves do id 
        public IActionResult Get(Guid Id)
        {
            try
            {
                Usuarios usuarios = _usuarioRepository.BuscarPorId(Id);
                return Ok(usuarios);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpDelete("{id}")] // Delete por id 
        public IActionResult Delete(Guid id)
        {
            try
            {
                _usuarioRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


        [HttpGet] //get de listagem
        public IActionResult Get()
        {
            try
            {
                List<Usuarios> ListarUsuario = _usuarioRepository.Listar();
                return Ok(ListarUsuario);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPut("{id}")] //Put de Atualizar
        public IActionResult Put(Guid id, Usuarios usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(id, usuario);
                return NoContent();
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


    }
}