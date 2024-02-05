using DesafioFullStack.Domain.Business;
using DesafioFullStack.Domain.DTO.Equipamento;
using DesafioFullStack.Domain.Repository;

namespace DesafioFullStack.Business.Implementation
{
    public class EquipamentoBusiness(IEquipamentoRepository repository) : IEquipamentoBusiness 
    {
        public  Task<EquipamentoDTO> Insert(EquipamentoDTO obj)
        {
            return  repository.Insert(obj);
        }

        public Task<EquipamentoDTO> Update(EquipamentoDTO obj)
        {
            return repository.Update(obj);
        }

        public Task<bool> Delete(int id)
        {
            return repository.Delete(id);
        }

        public Task<EquipamentoDTO> Select(int id)
        {
            return repository.Select(id);
        }

        public Task<IEnumerable<EquipamentoDTO>> SelectAll()
        {
            return repository.SelectAll();
        }
    }
}
