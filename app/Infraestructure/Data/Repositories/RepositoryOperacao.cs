using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryOperacao 
        : RepositoryBase<Operacao>, IRepositoryOperacao
    {
        private SqlContext _sqlContext { get; set; }

        public RepositoryOperacao(SqlContext sqlContext)
            : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }
    }
}