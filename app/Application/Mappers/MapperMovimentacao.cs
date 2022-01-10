using Application.Interfaces.Mappers;
using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class MapperMovimentacao : IMapperMovimentacao
    {
        public Movimentacao MapperDtoToEntity(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = new Movimentacao()
            {
                id              = movimentacaoDto.id,
                conta_corrente_id = movimentacaoDto.conta_corrente_id,
                operacao_id       = movimentacaoDto.operacao_id,
                dt_movimentacao = movimentacaoDto.dt_movimentacao,
                valor           = movimentacaoDto.valor,
                descricao       = movimentacaoDto.descricao,
                st_ativo        = movimentacaoDto.st_ativo,
            };

            return movimentacao;
        }

        public MovimentacaoDto MapperEntityToDto(Movimentacao movimentacao)
        {
            var dto = new MovimentacaoDto()
            {
                id       = movimentacao.id,
                st_ativo = movimentacao.st_ativo,
            };

            return dto;
        }

        public IEnumerable<MovimentacaoDto> MapperListMovimentacoesDto(IEnumerable<Movimentacao> movimentacoes)
        {
            var dto = movimentacoes.Select(movimentacao => new MovimentacaoDto {
                    id              = movimentacao.id,
                    conta_corrente_id = movimentacao.conta_corrente_id,
                    operacao_id       = movimentacao.operacao_id,
                    dt_movimentacao = movimentacao.dt_movimentacao,
                    valor           = movimentacao.valor,
                    descricao       = movimentacao.descricao,
                    st_ativo        = movimentacao.st_ativo,
                }
            );

            return dto;
        }   
    }
}