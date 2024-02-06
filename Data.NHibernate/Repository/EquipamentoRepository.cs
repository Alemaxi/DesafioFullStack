using DesafioFullStack.Domain.DTO.Equipamento;
using DesafioFullStack.Domain.Repository;
using NHibernate;
using System.Data.Entity;

namespace Data.NHibernate.Repository
{
    public class EquipamentoRepository(ISession session) : IEquipamentoRepository
    {
        public async Task<EquipamentoDTO> Insert(EquipamentoDTO obj)
        {
            ITransaction? transaction = null;
            try
            {
                transaction = session.BeginTransaction();
                session.Save(obj);
                transaction.Commit();
                return obj;
            } catch
            {
                Console.WriteLine("Erro ao inserir equipamento");
                await transaction?.RollbackAsync();
                return null;
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public async Task<EquipamentoDTO> Update(EquipamentoDTO obj)
        {
            ITransaction transaction = null;
            try
            {
                transaction = session.BeginTransaction();
                await session.UpdateAsync(obj);
                await transaction.CommitAsync();
                return obj;
            }
            catch
            {
                Console.WriteLine("Erro ao atualizar equipamento");
                await transaction?.RollbackAsync();
                return null;
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public Task<bool> Delete(int id)
        {
            ITransaction transaction = null;
            try
            {
                transaction = session.BeginTransaction();
                var equipamento = session.Get<EquipamentoDTO>(id);
                session.Delete(equipamento);
                transaction.Commit();
                return Task.FromResult(true);
            }
            catch
            {
                Console.WriteLine("Erro ao deletar equipamento");
                transaction?.Rollback();
                return Task.FromResult(false);
            }
            finally
            {
                transaction?.Dispose();
            }
        }

        public Task<EquipamentoDTO> Select(int id)
        {
            return session.GetAsync<EquipamentoDTO>(id);
        }

        public Task<IEnumerable<EquipamentoDTO>> SelectAll()
        {
            return Task.FromResult(session.Query<EquipamentoDTO>().AsEnumerable());
        }
    }
}
