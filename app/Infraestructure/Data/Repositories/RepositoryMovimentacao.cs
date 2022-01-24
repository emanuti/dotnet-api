using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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

        public List<Movimentacao> GetExtratoByIdContaDtInicioDtFim(int conta_corrente_id, DateTime dt_inicio, DateTime dt_fim)
        {
            return _sqlContext.Set<Movimentacao>()
                .Where<Movimentacao>(m => m.conta_corrente_id == conta_corrente_id)
                .Where<Movimentacao>(m => m.dt_movimentacao >= dt_inicio)
                .Where<Movimentacao>(m => m.dt_movimentacao <= dt_fim)
                .ToList();
        }
    }
}