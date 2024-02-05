using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain.Entity
{
    public class OrgaoGestor
    {
        public virtual int Id { get; set; }
        public virtual string? Nome { get; set; }
        public virtual string? Endereco { get; set; }
        public virtual string? Telefone { get; set; }
    }
}
