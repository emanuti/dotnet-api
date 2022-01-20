using Application.Interfaces.Mappers;
using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class MapperContaCorrente : IMapperContaCorrente
    {
        public ContaCorrente MapperDtoToEntity(ContaCorrenteDto contaCorrenteDto)
        {
            var contaCorrente = new ContaCorrente()
            {
                id                     = contaCorrenteDto.id,
                pessoa_fisica_id       = contaCorrenteDto.pessoa_fisica_id,
                agencia                = contaCorrenteDto.agencia,
                contacorrente          = contaCorrenteDto.contacorrente,
                dt_abertura            = contaCorrenteDto.dt_abertura,
                saldo_abertura         = contaCorrenteDto.saldo_abertura,
                saldo                  = contaCorrenteDto.saldo,
                dt_ultima_movimentacao = contaCorrenteDto.dt_ultima_movimentacao,
                st_ativo               = contaCorrenteDto.st_ativo
            };

            return contaCorrente;
        }

        public ContaCorrenteDto MapperEntityToDto(ContaCorrente contaCorrente)
        {
            var dto = new ContaCorrenteDto()
            {
                id       = contaCorrente.id,
                st_ativo = contaCorrente.st_ativo,
            };

            return dto;
        }

        public IEnumerable<ContaCorrenteDto> MapperListContasCorrentesDto(IEnumerable<ContaCorrente> contasCorretes)
        {
            var dto = contasCorretes.Select(contaCorrente => new ContaCorrenteDto {
                    id                     = contaCorrente.id,
                    pessoa_fisica_id       = contaCorrente.pessoa_fisica_id,
                    agencia                = contaCorrente.agencia,
                    contacorrente          = contaCorrente.contacorrente,
                    dt_abertura            = contaCorrente.dt_abertura,
                    saldo_abertura         = contaCorrente.saldo_abertura,
                    saldo                  = contaCorrente.saldo,
                    dt_ultima_movimentacao = contaCorrente.dt_ultima_movimentacao,
                    st_ativo               = contaCorrente.st_ativo
                }
            );

            return dto;
        }   
    }
}