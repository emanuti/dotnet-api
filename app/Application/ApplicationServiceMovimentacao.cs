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
    public class ApplicationServiceMovimentacao : IApplicationServiceMovimentacao
    {
        
        private readonly IServiceMovimentacao _serviceMovimentacao;
        private readonly IMapperMovimentacao _mapperMovimentacao;
        public ApplicationServiceMovimentacao(
            IServiceMovimentacao serviceMovimentacao,
            IMapperMovimentacao mapperMovimentacao
        )
        {
            this._serviceMovimentacao = serviceMovimentacao;
            this._mapperMovimentacao = mapperMovimentacao;
        }

        public void Add(MovimentacaoDto movimentacaoDto) 
        {
            var movimentacao = this._mapperMovimentacao
                .MapperDtoToEntity(movimentacaoDto);

            this._serviceMovimentacao
                .Add(movimentacao);
        }

        public IEnumerable<MovimentacaoDto> GetAll()
        {
            var pessoasFisicas = this._serviceMovimentacao
                .GetAll();

            return this._mapperMovimentacao
                .MapperListMovimentacoesDto(pessoasFisicas);
        }

        public MovimentacaoDto GetById(int id)
        {
            var movimentacao = this._serviceMovimentacao
                .GetById(id);

            return this._mapperMovimentacao
                .MapperEntityToDto(movimentacao);
        }

        public void Remove(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = this._mapperMovimentacao
                .MapperDtoToEntity(movimentacaoDto);

            this._serviceMovimentacao.Remove(movimentacao);
        }

        public void Update(MovimentacaoDto movimentacaoDto)
        {
            var movimentacao = this._mapperMovimentacao
                .MapperDtoToEntity(movimentacaoDto);

            this._serviceMovimentacao.Update(movimentacao);
        }
    }
}