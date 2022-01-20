using Application.DTOs;
using System.Collections.Generic;

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