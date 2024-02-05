using DesafioFullStack.Domain.Entity;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.NHibernate.Mappings
{
    public class TipoEquipamentoMap : ClassMapping<TipoEquipamento>
    {
        public TipoEquipamentoMap()
        {
            Id(b => b.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
            });

            Property(b => b.Nome, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("Nome");
            });

            Property(b => b.Descricao, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("Descricao");
            });

            Table("TipoEquipamento");
        }
    }
}
