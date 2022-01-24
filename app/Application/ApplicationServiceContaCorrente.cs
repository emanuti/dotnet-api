using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Application.Interfaces.Mappers;
using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application
{
    public class ApplicationServiceContaCorrente : IApplicationServiceContaCorrente
    {
        
        private readonly IServiceContaCorrente _serviceContaCorrente;
        private readonly IMapperContaCorrente _mapperContaCorrente;
        public ApplicationServiceContaCorrente(
            IServiceContaCorrente serviceContaCorrente,
            IMapperContaCorrente mapperContaCorrente
        )
        {
            this._serviceContaCorrente = serviceContaCorrente;
            this._mapperContaCorrente  = mapperContaCorrente;
        }

        public void Add(ContaCorrenteDto ContaCorrenteDto) 
        {
            var ContaCorrente = this._mapperContaCorrente
                .MapperDtoToEntity(ContaCorrenteDto);

            this._serviceContaCorrente
                .Add(ContaCorrente);
        }

        public IEnumerable<ContaCorrenteDto> GetAll()
        {
            var pessoasFisicas = this._serviceContaCorrente
                .GetAll();

            return this._mapperContaCorrente
                .MapperListContasCorrentesDto(pessoasFisicas);
        }

        public ContaCorrenteDto GetById(int id)
        {
            var ContaCorrente = this._serviceContaCorrente
                .GetById(id);

            return this._mapperContaCorrente
                .MapperEntityToDto(ContaCorrente);
        }

        public void Remove(ContaCorrenteDto ContaCorrenteDto)
        {
            var ContaCorrente = this._mapperContaCorrente
                .MapperDtoToEntity(ContaCorrenteDto);

            this._serviceContaCorrente.Remove(ContaCorrente);
        }

        public void Update(ContaCorrenteDto ContaCorrenteDto)
        {
            var ContaCorrente = this._mapperContaCorrente
                .MapperDtoToEntity(ContaCorrenteDto);

            this._serviceContaCorrente.Update(ContaCorrente);
        }

        public ContaCorrente GetByAgenciaEContaCorrente(
            string agencia, 
            string conta_corrente
        ) {
            return this._serviceContaCorrente
                .GetByAgenciaEContaCorrente(agencia, conta_corrente);
        }
    }
}