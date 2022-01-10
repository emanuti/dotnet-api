using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContaCorrente : Base
    {
        public int id { get; set; }
        public int pessoa_fisica_id { get; set; }
        public string agencia { get; set; }
        public string contacorrente { get; set; }
        public DateTime dt_abertura { get; set; }
        public float saldo_abertura { get; set; }
        public float saldo { get; set; }
        public DateTime dt_ultima_movimentacao { get; set; }
        public bool st_ativo { get; set; }
    }
}