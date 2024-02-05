using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain.Entity
{
    public class TipoEquipamento
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public object Descricao { get; set; }
    }
}
