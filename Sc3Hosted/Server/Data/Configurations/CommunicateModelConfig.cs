﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class CommunicateModelConfig : IEntityTypeConfiguration<CommunicateModel>
{
    public void Configure(EntityTypeBuilder<CommunicateModel> builder)
    {
        builder.ToTable("CommunicateModels", x => x.IsTemporal());
        builder.HasKey(x => new { x.CommunicateId, x.ModelId });
        builder.Property(x => x.ModelId).IsRequired();
        builder.Property(x => x.CommunicateId).IsRequired();
        builder.HasOne(x => x.Model).WithMany(x => x.CommunicateModels).HasForeignKey(x => x.ModelId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Communicate).WithMany(x => x.CommunicateModels).HasForeignKey(x => x.CommunicateId).OnDelete(DeleteBehavior.Restrict);
    }
}
