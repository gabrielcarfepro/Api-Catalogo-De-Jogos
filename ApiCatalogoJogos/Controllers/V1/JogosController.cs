using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Controller.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        // GET, POST, PUT, PATCH, DELETE
        
        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {
            return Ok();
        }

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<object>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo( object jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")] // PUT atualiza o recurso inteiro (nome, preço, etc)
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, object jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")] // PATCH atualiza um atributo específico (preço)
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }


    }
}