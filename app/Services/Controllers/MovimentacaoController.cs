using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Interfaces;
using Application.DTOs;

namespace Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimentacaoController : Controller
    {
        private readonly IApplicationServiceMovimentacao _applicationServiceMovimentacao;

        public MovimentacaoController(IApplicationServiceMovimentacao ApplicationServiceMovimentacao)
        {
            _applicationServiceMovimentacao = ApplicationServiceMovimentacao;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceMovimentacao.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceMovimentacao.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] MovimentacaoDto MovimentacaoDto)
        {
            try {
                if(MovimentacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceMovimentacao.Add(MovimentacaoDto);

                return Ok("Registro de movimentação cadastrado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] MovimentacaoDto MovimentacaoDto)
        {
            try {
                if(MovimentacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceMovimentacao.Update(MovimentacaoDto);

                return Ok("Registro de movimentação atualizado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] MovimentacaoDto MovimentacaoDto)
        {
            try {
                if(MovimentacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceMovimentacao.Remove(MovimentacaoDto);

                return Ok("Registro de movimentação removido com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }
    }
}