using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModeloDDD.Domain.Contracts.Services;
using ModeloDDD.Domain.Entities;

namespace ModeloDDD.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }
        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}


        [HttpPost]
        public string Get()
        {
            return "teste";
        }

        [HttpPost]
        [Route("Register")]
        public Usuario Register(usuarioDTO user)
        {
            HttpResponseMessage response = new HttpResponseMessage();

           //var usuario = _service.Register(name, email, senha, confirmacaoSenha);

            return new Usuario("t","t","t");
        }


        

        public class usuarioDTO
        {
            public string  name { get; set; }
            public string email { get; set; }
            public string senha { get; set; }
            public string confirmacaoSenha  { get; set; }
        }
    }
}