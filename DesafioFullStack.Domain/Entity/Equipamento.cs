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
        public string? NomeEquipamento { get; set; }
        public string? NumeroSerie { get; set; }
        public string? EnderecoHardware { get; set; }
        public string? EnderecoHadware { get; set; }
        public string? SimCard { get; set; }
        public string? Operadora { get; set; }
        public bool RedeAtiva { get; set; }
        public bool MemoriaDoCartao { get; set; }
        public OrgaoGestor? OrgaoGestor { get; set; }
        public TipoEquipamento? TipoEquipamento { get; set; }
        public Fabricante? Fabricante { get; set; }

    }
}
