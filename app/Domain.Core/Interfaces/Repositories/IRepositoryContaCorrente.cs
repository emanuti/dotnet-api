using Domain.Entities;

namespace Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryContaCorrente : IRepositoryBase<ContaCorrente>
    { 
        ContaCorrente GetByAgenciaEContaCorrente(string agencia, string conta_corrente);
    }
}