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
    public class ContaCorrenteController : Controller
    {
        private readonly IApplicationServiceContaCorrente _applicationServiceContaCorrente;

        public ContaCorrenteController(IApplicationServiceContaCorrente ApplicationServiceContaCorrente)
        {
            _applicationServiceContaCorrente = ApplicationServiceContaCorrente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceContaCorrente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceContaCorrente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ContaCorrenteDto ContaCorrenteDto)
        {
            try {
                if(ContaCorrenteDto == null) {
                    return NotFound();
                }

                _applicationServiceContaCorrente.Add(ContaCorrenteDto);

                return Ok("Registro de movimentação cadastrado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ContaCorrenteDto ContaCorrenteDto)
        {
            try {
                if(ContaCorrenteDto == null) {
                    return NotFound();
                }

                _applicationServiceContaCorrente.Update(ContaCorrenteDto);

                return Ok("Registro de movimentação atualizado com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ContaCorrenteDto ContaCorrenteDto)
        {
            try {
                if(ContaCorrenteDto == null) {
                    return NotFound();
                }

                _applicationServiceContaCorrente.Remove(ContaCorrenteDto);

                return Ok("Registro de movimentação removido com sucesso!");
            } catch(Exception e) {
                throw e;
            }
        }
    }
}