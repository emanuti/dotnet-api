using Application.Interfaces.Mappers;
using Domain.Entities;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class MapperPessoaFisica : IMapperPessoaFisica
    {
        public PessoaFisica MapperDtoToEntity(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = new PessoaFisica()
            {
                id      = pessoaFisicaDto.id,
                nome    = pessoaFisicaDto.nome,
                cpf     = pessoaFisicaDto.cpf,
                dt_nascimento = pessoaFisicaDto.dt_nascimento,
                nu_sexo  = pessoaFisicaDto.nu_sexo,
                st_ativo = pessoaFisicaDto.st_ativo,
            };

            return pessoaFisica;
        }

        public PessoaFisicaDto MapperEntityToDto(PessoaFisica pessoaFisica)
        {
            var dto = new PessoaFisicaDto()
            {
                id       = pessoaFisica.id,
                nome     = pessoaFisica.nome,
                cpf      = pessoaFisica.cpf,
                dt_nascimento = pessoaFisica.dt_nascimento,
                nu_sexo  = pessoaFisica.nu_sexo,
                st_ativo = pessoaFisica.st_ativo,
            };

            return dto;
        }

        public IEnumerable<PessoaFisicaDto> MapperListPessoasFisicasDto(IEnumerable<PessoaFisica> pessoasFisicas)
        {
            var dto = pessoasFisicas.Select(pessoaFisica => new PessoaFisicaDto {
                    id       = pessoaFisica.id,
                    nome     = pessoaFisica.nome,
                    cpf      = pessoaFisica.cpf,
                    dt_nascimento = pessoaFisica.dt_nascimento,
                    nu_sexo  = pessoaFisica.nu_sexo,
                    st_ativo = pessoaFisica.st_ativo,
                }
            );

            return dto;
        }        
    }
}