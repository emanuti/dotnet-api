using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movimentacao : Base
    {
        public int id { get; set; }
        public int conta_corrente_id { get; set; }
        public int operacao_id { get; set; }
        public DateTime dt_movimentacao { get; set; }
        public float valor { get; set; }
        public string descricao { get; set; }
        public bool st_ativo { get; set; }
    }
}