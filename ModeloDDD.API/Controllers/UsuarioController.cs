using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ModeloDDD.API.Services;
using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.DTOs;
using ModeloDDD.Domain.Entities;

namespace ModeloDDD.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public string Get()
        {
            return "teste";
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<Usuario>> Register([FromBody] UsuarioDTO usuario)
        {
            var user = new Usuario(usuario.Nome, usuario.Email, usuario.Password);
            if (!user.Valid)
                return BadRequest(user.Notifications);

            try
            {
                await _service.Register(user);
                user.HidePassword();
                return user;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível registrar o usuário." + ex.Message);
            }
        }

        [HttpPost]
        [Route("Authenticate")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UsuarioDTO usuario)
        {
            try
            {
                // Recupera o usuário
                var user = await _service.Authenticate(usuario.Email, usuario.Password);

                // Verifica se o usuário existe
                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos" });

                // Gera o Token
                var token = TokenService.GenerateToken(user);

                // Oculta a senha
                usuario.Password = "";

                // Retorna os dados
                return new
                {
                    user,
                    token
                };
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível registrar o usuário. " + ex.Message);
            }

           
        }
    }
}