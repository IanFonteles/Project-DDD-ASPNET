using CrudDDD.Infra.Data.EntityConfig;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Infra.Data.Contexto {
    public class ProjectDDDContext : DbContext {
        public ProjectDDDContext() : base("ProjectDDD") {
        }

        public DbSet<FisicPerson> FisicPersons { get; set; }
        public DbSet<JuridicPerson> JuridicPersons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
               .Where(p => p.Name == p.ReflectedType.Name + "Id")
               .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new FisicPersonConfiguration());
            modelBuilder.Configurations.Add(new JuridicPersonConfiguration());


        }

        public override int SaveChanges() {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegisterDate") != null)) {
                if (entry.State == EntityState.Added) {
                    entry.Property("RegisterDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified) {
                    entry.Property("RegisterDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
