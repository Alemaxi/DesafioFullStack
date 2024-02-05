using DesafioFullStack.Domain.Entity;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.NHibernate.Mappings
{
    public class OrgaoGestorMap : ClassMapping<OrgaoGestor>
    {
        public OrgaoGestorMap()
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

            Property(b => b.Endereco, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("Endereco");
            });

            Property(b => b.Telefone, x =>
            {
                x.Length(150);
                x.Type(NHibernateUtil.String);
                x.Column("Telefone");
            });

            Table("OrgaoGestor");
        }  
    }
}
