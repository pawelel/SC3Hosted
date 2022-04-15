﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class ModelConfig : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasKey(x => x.ModelId);
        builder.Property(x => x.ModelId).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(200);
        builder.Property(x => x.DeviceId).IsRequired();
        builder.HasOne(x=>x.Device).WithMany(x=>x.Models).HasForeignKey(x=>x.DeviceId);
    }
}
