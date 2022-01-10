using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Entities;

namespace Domain.Service
{
    public class ServicePessoaFisica : ServiceBase<PessoaFisica>, IServicePessoaFisica
    {
        private readonly IRepositoryPessoaFisica _repoPessoaFisica;
        
        public ServicePessoaFisica(IRepositoryPessoaFisica repo) 
            : base(repo)
        {
            this._repoPessoaFisica = repo;       
        }
    }
}