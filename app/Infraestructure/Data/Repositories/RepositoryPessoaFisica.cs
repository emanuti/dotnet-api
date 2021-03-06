using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryPessoaFisica
        : RepositoryBase<PessoaFisica>, IRepositoryPessoaFisica
    {
        private SqlContext _sqlContext { get; set; }
        
        public RepositoryPessoaFisica(SqlContext sqlContext) 
            : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }
    }
}