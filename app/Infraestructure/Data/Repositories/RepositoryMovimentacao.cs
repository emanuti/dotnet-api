using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Core.Interfaces.Repositories;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryMovimentacao 
        : RepositoryBase<Movimentacao>, IRepositoryMovimentacao
    {
        private SqlContext _sqlContext { get; set; }

        public RepositoryMovimentacao(SqlContext sqlContext) : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }
    }
}