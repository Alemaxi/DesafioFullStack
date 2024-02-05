using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain.Entity
{
    public class Equipamento
    {
        public virtual int Id { get; set; }
        public virtual string? NumeroSerie { get; set; }
        public virtual string? IMEI { get; set; }
        public virtual string? EnderecoHardware { get; set; }
        public virtual string? SimCard { get; set; }
        public virtual string? Operadora { get; set; }
        public virtual bool RedeAtiva { get; set; }
        public virtual bool MemoriaDoCartao { get; set; }
        public virtual int OrgaoGestorID { get; set; }
        public virtual int TipoEquipamentoID { get; set; }
        public virtual int FabricanteID { get; set; }

    }
}
