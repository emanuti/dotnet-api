using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Mappers
{
    public interface IMapperPessoaFisica
    {
        PessoaFisica MapperDtoToEntity(PessoaFisicaDto pessoaFisica);
        IEnumerable<PessoaFisicaDto> MapperListPessoasFisicasDto(IEnumerable<PessoaFisica> pessoasFisicas);
        PessoaFisicaDto MapperEntityToDto(PessoaFisica pessoaFisica);
    }
}