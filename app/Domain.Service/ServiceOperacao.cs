using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Domain.Service
{
    public class ServiceOperacao : ServiceBase<Operacao>, IServiceOperacao
    {
        private readonly IRepositoryOperacao _repoOperacao;
        
        public ServiceOperacao(IRepositoryOperacao repo) 
            : base(repo)
        {
            this._repoOperacao = repo;       
        }
    }
}