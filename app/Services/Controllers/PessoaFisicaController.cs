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
    public class PessoaFisicaController : Controller
    {
        private readonly IApplicationServicePessoaFisica _applicationServicePessoaFisica;

        public PessoaFisicaController(IApplicationServicePessoaFisica ApplicationServicePessoaFisica)
        {
            _applicationServicePessoaFisica = ApplicationServicePessoaFisica;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicePessoaFisica.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServicePessoaFisica.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PessoaFisicaDto pessoaFisicaDto)
        {
            try {
                if(pessoaFisicaDto == null) {
                    return NotFound();
                }

                _applicationServicePessoaFisica.Add(pessoaFisicaDto);

                return Ok("Registro de pessoa cadastrado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] PessoaFisicaDto pessoaFisicaDto)
        {
            try {
                if(pessoaFisicaDto == null) {
                    return NotFound();
                }

                _applicationServicePessoaFisica.Update(pessoaFisicaDto);

                return Ok("Registro de pessoa atualizado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PessoaFisicaDto pessoaFisicaDto)
        {
            try {
                if(pessoaFisicaDto == null) {
                    return NotFound();
                }

                _applicationServicePessoaFisica.Remove(pessoaFisicaDto);

                return Ok("Registro de pessoa removido com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }
    }
}