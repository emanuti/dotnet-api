using Application.Interfaces.Mappers;
using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class MapperOperacao : IMapperOperacao
    {
        public Operacao MapperDtoToEntity(OperacaoDto operacaoDto)
        {
            var operacao = new Operacao()
            {
                id         = operacaoDto.id,
                nome       = operacaoDto.nome,
                tipo_id    = operacaoDto.tipo_id,
                st_ativo   = operacaoDto.st_ativo,
            };

            return operacao;
        }

        public OperacaoDto MapperEntityToDto(Operacao operacao)
        {
            var dto = new OperacaoDto()
            {
                id       = operacao.id,
                st_ativo = operacao.st_ativo,
            };

            return dto;
        }

        public IEnumerable<OperacaoDto> MapperListOperacoesDto(IEnumerable<Operacao> operacoes)
        {
            var dto = operacoes.Select(operacao => new OperacaoDto {
                    id         = operacao.id,
                    nome       = operacao.nome,
                    tipo_id    = operacao.tipo_id,
                    st_ativo   = operacao.st_ativo,
                }
            );

            return dto;
        }   
    }
}