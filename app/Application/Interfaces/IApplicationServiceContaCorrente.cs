using Application.DTOs;
using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IApplicationServiceContaCorrente
    {
        void Add(ContaCorrenteDto contaCorrenteDto);

        void Update(ContaCorrenteDto contaCorrenteDto);

        void Remove(ContaCorrenteDto contaCorrenteDto);

        IEnumerable<ContaCorrenteDto> GetAll();

        ContaCorrenteDto GetById(int id);

        ContaCorrente GetByAgenciaEContaCorrente(string agencia, string conta_corrente);
    }
}