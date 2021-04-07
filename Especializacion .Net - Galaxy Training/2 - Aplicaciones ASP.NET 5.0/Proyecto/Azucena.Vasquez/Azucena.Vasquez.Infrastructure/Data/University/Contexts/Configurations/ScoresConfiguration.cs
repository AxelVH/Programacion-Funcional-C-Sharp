﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Azucena.Vasquez.Infrastructure.Data.University.Contexts;
using Azucena.Vasquez.Infrastructure.Data.University.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace Azucena.Vasquez.Infrastructure.Data.University.Contexts.Configurations
{
    public partial class ScoresConfiguration : IEntityTypeConfiguration<Scores>
    {
        public void Configure(EntityTypeBuilder<Scores> entity)
        {
            entity.ToTable("Scores", "University");

            entity.Property(e => e.CourseId).HasColumnName("Course_Id");

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450)
                .HasColumnName("User_Id");

            entity.HasOne(d => d.Course)
                .WithMany(p => p.Scores)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CourseId");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Scores)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Scores> entity);
    }
}