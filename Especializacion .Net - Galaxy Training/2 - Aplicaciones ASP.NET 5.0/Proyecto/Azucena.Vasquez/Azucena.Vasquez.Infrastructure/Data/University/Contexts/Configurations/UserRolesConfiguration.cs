﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Azucena.Vasquez.Infrastructure.Data.University.Contexts;
using Azucena.Vasquez.Infrastructure.Data.University.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Azucena.Vasquez.Infrastructure.Data.University.Contexts.Configurations
{
    public partial class UserRolesConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> entity)
        {
            entity.HasKey(e => new { e.UserId, e.RoleId });

            entity.ToTable("UserRoles", "Security");

            entity.HasIndex(e => e.RoleId, "IX_UserRoles_RoleId");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId);

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UserRoles> entity);
    }
}
