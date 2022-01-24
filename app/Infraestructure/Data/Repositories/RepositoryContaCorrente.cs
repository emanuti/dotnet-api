using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryContaCorrente 
        : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        private SqlContext _sqlContext { get; set; }

        public RepositoryContaCorrente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }

        public ContaCorrente GetByAgenciaEContaCorrente(string agencia, string conta_corrente)
        {
            return _sqlContext.Set<ContaCorrente>()
                .Where<ContaCorrente>(ContaCorrente => ContaCorrente.agencia == agencia)
                .Where<ContaCorrente>(ContaCorrente => ContaCorrente.contacorrente == conta_corrente)
                .FirstOrDefault();
        }
    }
}