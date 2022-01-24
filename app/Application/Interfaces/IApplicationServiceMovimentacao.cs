using System;
using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicationServiceMovimentacao
    {
        void Add(MovimentacaoDto movimentacaoDto);

        void Update(MovimentacaoDto movimentacaoDto);

        void Remove(MovimentacaoDto movimentacaoDto);

        IEnumerable<MovimentacaoDto> GetAll();

        MovimentacaoDto GetById(int id);

        List<Movimentacao> GetExtratoByIdContaDtInicioDtFim(int conta_corrente_id, DateTime dt_inicio, DateTime dt_fim);
    }
}