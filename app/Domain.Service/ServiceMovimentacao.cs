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
    }
}