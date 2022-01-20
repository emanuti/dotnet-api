using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Mappers{
    public interface IMapperOperacao
    {
        Operacao MapperDtoToEntity(OperacaoDto operacao);
        IEnumerable<OperacaoDto> MapperListOperacoesDto(IEnumerable<Operacao> operacoes);
        OperacaoDto MapperEntityToDto(Operacao operacao);
    }
}