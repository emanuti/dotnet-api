using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Application.Interfaces.Mappers;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationServicePessoaFisica : IApplicationServicePessoaFisica
    {
        private readonly IServicePessoaFisica _servicePessoaFisica;
        private readonly IMapperPessoaFisica _mapperPessoaFisica;
        public ApplicationServicePessoaFisica(
            IServicePessoaFisica servicePessoaFisica,
            IMapperPessoaFisica mapperPessoaFisica
        )
        {
            this._servicePessoaFisica = servicePessoaFisica;
            this._mapperPessoaFisica = mapperPessoaFisica;
        }

        public void Add(PessoaFisicaDto pessoaFisicaDto) 
        {
            var pessoaFisica = this._mapperPessoaFisica
                .MapperDtoToEntity(pessoaFisicaDto);

            this._servicePessoaFisica
                .Add(pessoaFisica);
        }

        public IEnumerable<PessoaFisicaDto> GetAll()
        {
            var pessoasFisicas = this._servicePessoaFisica
                .GetAll();

            return this._mapperPessoaFisica
                .MapperListPessoasFisicasDto(pessoasFisicas);
        }

        public PessoaFisicaDto GetById(int id)
        {
            var pessoaFisica = this._servicePessoaFisica
                .GetById(id);

            return this._mapperPessoaFisica
                .MapperEntityToDto(pessoaFisica);
        }

        public void Remove(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = this._mapperPessoaFisica
                .MapperDtoToEntity(pessoaFisicaDto);

            this._servicePessoaFisica.Remove(pessoaFisica);
        }

        public void Update(PessoaFisicaDto pessoaFisicaDto)
        {
            var pessoaFisica = this._mapperPessoaFisica
                .MapperDtoToEntity(pessoaFisicaDto);

            this._servicePessoaFisica.Update(pessoaFisica);
        }
    }
}