using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain.Entity
{
    public class TipoEquipamento
    {
        public virtual int Id { get; set; }
        public virtual string? Nome { get; set; }
        public virtual object Descricao { get; set; }
    }
}
