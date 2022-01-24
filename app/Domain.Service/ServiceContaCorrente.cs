using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Domain.Service
{
    public class ServiceContaCorrente : ServiceBase<ContaCorrente>, IServiceContaCorrente
    {
        private readonly IRepositoryContaCorrente _repoContaCorrente;
        
        public ServiceContaCorrente(IRepositoryContaCorrente repo) 
            : base(repo)
        {
            this._repoContaCorrente = repo;       
        }

        public ContaCorrente GetByAgenciaEContaCorrente(string agencia, string conta_corrente)
        {
            return _repoContaCorrente
                .GetByAgenciaEContaCorrente(agencia, conta_corrente);
        }
    }
}