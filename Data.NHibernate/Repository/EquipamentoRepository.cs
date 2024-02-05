using DesafioFullStack.Domain.DTO.Equipamento;
using DesafioFullStack.Domain.Repository;

namespace Data.NHibernate.Repository
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        public Task<EquipamentoDTO> Insert(EquipamentoDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<EquipamentoDTO> Update(EquipamentoDTO obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EquipamentoDTO> Select(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipamentoDTO>> SelectAll()
        {
            return Task.FromResult<IEnumerable<EquipamentoDTO>>(null);
        }
    }
}
