using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
            catch (Exception)
            {
                return BadRequest("Não foi possível registrar o usuário.");
            }
        }
    }
}