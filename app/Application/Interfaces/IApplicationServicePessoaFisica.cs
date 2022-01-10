using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationServicePessoaFisica
    {
        void Add(PessoaFisicaDto pessoaFisicaDto);

        void Update(PessoaFisicaDto pessoaFisicaDto);

        void Remove(PessoaFisicaDto pessoaFisicaDto);

        IEnumerable<PessoaFisicaDto> GetAll();

        PessoaFisicaDto GetById(int id);
    }
}