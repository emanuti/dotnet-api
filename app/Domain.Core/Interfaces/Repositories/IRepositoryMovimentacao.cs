using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryMovimentacao : IRepositoryBase<Movimentacao>
    {
        List<Movimentacao> GetExtratoByIdContaDtInicioDtFim(int conta_corrente_id, DateTime dt_inicio, DateTime dt_fim);
    }
}