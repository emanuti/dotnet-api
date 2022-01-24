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
    public class OperacaoController : Controller
    {
        private readonly IApplicationServiceOperacao _applicationServiceOperacao;

        public OperacaoController(IApplicationServiceOperacao ApplicationServiceOperacao)
        {
            _applicationServiceOperacao = ApplicationServiceOperacao;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceOperacao.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceOperacao.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] OperacaoDto OperacaoDto)
        {
            try {
                if(OperacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceOperacao.Add(OperacaoDto);

                return Ok("Registro de operação cadastrado com sucesso!");
            } catch(Exception e) {
                return Problem(e.Message);
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] OperacaoDto OperacaoDto)
        {
            try {
                if(OperacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceOperacao.Update(OperacaoDto);

                return Ok("Registro de operação atualizado com sucesso!");
            } catch(Exception e) {
                return Problem(e.Message);
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] OperacaoDto OperacaoDto)
        {
            try {
                if(OperacaoDto == null) {
                    return NotFound();
                }

                _applicationServiceOperacao.Remove(OperacaoDto);

                return Ok("Registro de operação removido com sucesso!");
            } catch(Exception e) {
                return Problem(e.Message);
            }
        }
    }
}