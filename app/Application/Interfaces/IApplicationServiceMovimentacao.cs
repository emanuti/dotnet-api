using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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