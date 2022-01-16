using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

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
    }
}