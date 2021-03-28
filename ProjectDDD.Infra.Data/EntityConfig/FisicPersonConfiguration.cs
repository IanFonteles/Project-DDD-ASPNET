﻿using ProjectDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace CrudDDD.Infra.Data.EntityConfig {
    public class FisicPersonConfiguration : EntityTypeConfiguration<FisicPerson> {

        public FisicPersonConfiguration() {
            HasKey(c => c.ClientId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);
            Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(8);
            Property(c => c.CellNumber)
                .IsRequired()
                 .HasMaxLength(9);
            Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(300);
            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);
            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
