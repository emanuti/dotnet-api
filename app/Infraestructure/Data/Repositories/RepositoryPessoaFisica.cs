using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryPessoaFisica
        : RepositoryBase<PessoaFisica>, IRepositoryPessoaFisica
    {
        private SqlContext _sqlContext { get; set; }
        
        public RepositoryPessoaFisica(SqlContext sqlContext)
        {
            this._sqlContext = sqlContext;
        }
    }
}