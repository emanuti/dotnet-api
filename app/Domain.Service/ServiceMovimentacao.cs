using System;
using System.Collections.Generic;
using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Domain.Service
{
    public class ServiceMovimentacao : ServiceBase<Movimentacao>, IServiceMovimentacao
    {
        private readonly IRepositoryMovimentacao _repoMovimentacao;
        
        public ServiceMovimentacao(IRepositoryMovimentacao repo) 
            : base(repo)
        {
            this._repoMovimentacao = repo;       
        }

        public List<Movimentacao> GetExtratoByIdContaDtInicioDtFim(
            int conta_corrente_id,
            DateTime dt_inicio, 
            DateTime dt_fim
        ) {
            return this._repoMovimentacao
                .GetExtratoByIdContaDtInicioDtFim(conta_corrente_id, dt_inicio, dt_fim);
        }
    }
}