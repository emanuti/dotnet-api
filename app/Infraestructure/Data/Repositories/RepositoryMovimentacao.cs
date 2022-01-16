using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryMovimentacao 
        : RepositoryBase<Movimentacao>, IRepositoryMovimentacao
    {
        private SqlContext _sqlContext { get; set; }

        public RepositoryMovimentacao(SqlContext sqlContext)
            : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }
    }
}