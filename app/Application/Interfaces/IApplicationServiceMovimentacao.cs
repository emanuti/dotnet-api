using Application.DTOs;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IApplicationServiceMovimentacao
    {
        void Add(MovimentacaoDto movimentacaoDto);

        void Update(MovimentacaoDto movimentacaoDto);

        void Remove(MovimentacaoDto movimentacaoDto);

        IEnumerable<MovimentacaoDto> GetAll();

        MovimentacaoDto GetById(int id);
    }
}