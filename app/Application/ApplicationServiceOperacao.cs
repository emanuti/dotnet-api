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
    public class ApplicationServiceOperacao : IApplicationServiceOperacao
    {
        
        private readonly IServiceOperacao _serviceOperacao;
        private readonly IMapperOperacao _mapperOperacao;
        public ApplicationServiceOperacao(
            IServiceOperacao serviceOperacao,
            IMapperOperacao mapperOperacao
        )
        {
            this._serviceOperacao = serviceOperacao;
            this._mapperOperacao = mapperOperacao;
        }

        public void Add(OperacaoDto OperacaoDto) 
        {
            var Operacao = this._mapperOperacao
                .MapperDtoToEntity(OperacaoDto);

            this._serviceOperacao
                .Add(Operacao);
        }

        public IEnumerable<OperacaoDto> GetAll()
        {
            var pessoasFisicas = this._serviceOperacao
                .GetAll();

            return this._mapperOperacao
                .MapperListOperacoesDto(pessoasFisicas);
        }

        public OperacaoDto GetById(int id)
        {
            var Operacao = this._serviceOperacao
                .GetById(id);

            return this._mapperOperacao
                .MapperEntityToDto(Operacao);
        }

        public void Remove(OperacaoDto OperacaoDto)
        {
            var Operacao = this._mapperOperacao
                .MapperDtoToEntity(OperacaoDto);

            this._serviceOperacao.Remove(Operacao);
        }

        public void Update(OperacaoDto OperacaoDto)
        {
            var Operacao = this._mapperOperacao
                .MapperDtoToEntity(OperacaoDto);

            this._serviceOperacao.Update(Operacao);
        }
    }
}