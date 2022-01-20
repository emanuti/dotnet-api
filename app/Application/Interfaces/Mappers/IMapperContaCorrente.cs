using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Mappers{
    public interface IMapperContaCorrente
    {
        ContaCorrente MapperDtoToEntity(ContaCorrenteDto contaCorrente);
        IEnumerable<ContaCorrenteDto> MapperListContasCorrentesDto(IEnumerable<ContaCorrente> contasCorrentes);
        ContaCorrenteDto MapperEntityToDto(ContaCorrente contaCorrente);
    }
}