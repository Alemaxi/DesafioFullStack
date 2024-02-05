using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Domain.Entity
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string? NumeroSerie { get; set; }
        public string? IMEI { get; set; }
        public string? EnderecoHardware { get; set; }
        public string? SimCard { get; set; }
        public string? Operadora { get; set; }
        public bool RedeAtiva { get; set; }
        public bool MemoriaDoCartao { get; set; }
        public int OrgaoGestorID { get; set; }
        public int TipoEquipamentoID { get; set; }
        public int FabricanteID { get; set; }

    }
}
