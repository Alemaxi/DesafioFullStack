using DesafioFullStack.Domain.Entity;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.NHibernate.Mappings
{
    public class EquipamentoMap : ClassMapping<Equipamento>
    {
        public EquipamentoMap()
        {
            Id(b => b.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
            });

            Property(b => b.NumeroSerie, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("NumeroSerie");
            });

            Property(b => b.EnderecoHardware, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("EnderecoHardware");
            });

            Property(b => b.SimCard, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("SimCard");
            });

            Property(b => b.Operadora, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("Operadora");
            });

            Property(b => b.RedeAtiva, x =>
            {
                x.Type(NHibernateUtil.Boolean);
                x.Column("RedeAtiva");
            });

            Property(b => b.MemoriaDoCartao, x =>
            {
                x.Type(NHibernateUtil.Boolean);
                x.Column("MemoriaDoCartao");
            });

            Property(b => b.OrgaoGestorID, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("OrgaoGestorID");
            });

            Property(b => b.TipoEquipamentoID, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("TipoEquipamentoID");
            });

            Property(b => b.FabricanteID, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("FabricanteID");
            });

            Property(b => b.IMEI, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("IMEI");
            });

            Table("Equipamento");
        }
    }
}
