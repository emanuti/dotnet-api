using Domain.Entities;

namespace Domain.Core.Interfaces.Services
{
    public interface IServiceContaCorrente : IServiceBase<ContaCorrente>
    {
        ContaCorrente GetByAgenciaEContaCorrente(string agencia, string conta_corrente);
    }
}