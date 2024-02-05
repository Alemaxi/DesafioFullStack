using DesafioFullStack.Domain.Application;
using DesafioFullStack.Domain.Business;
using DesafioFullStack.Domain.DTO.Equipamento;
using DesafioFullStack.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFullStack.Application.Implementations
{
    public class EquipamentoApplication(IEquipamentoBusiness business) : IEquipamentoApplication
    {
        public Task<EquipamentoDTO> Insert(EquipamentoDTO obj)
        {
            return business.Insert(obj);
        }

        public Task<EquipamentoDTO> Update(EquipamentoDTO obj)
        {
            return business.Update(obj);
        }

        public Task<bool> Delete(int id)
        {
            return business.Delete(id);
        }

        public Task<EquipamentoDTO> Select(int id)
        {
            return business.Select(id);
        }

        public Task<IEnumerable<EquipamentoDTO>> SelectAll()
        {
            return business.SelectAll();
        }
    }
}
