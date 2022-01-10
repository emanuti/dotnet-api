using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces.Mappers{
    public interface IMapperMovimentacao
    {
        Movimentacao MapperDtoToEntity(MovimentacaoDto movimentacao);
        IEnumerable<MovimentacaoDto> MapperListMovimentacoesDto(IEnumerable<Movimentacao> movimentacoes);
        MovimentacaoDto MapperEntityToDto(Movimentacao movimentacao);
    }
}