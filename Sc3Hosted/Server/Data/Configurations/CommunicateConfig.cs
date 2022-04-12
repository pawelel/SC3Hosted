﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class CommunicateConfig : IEntityTypeConfiguration<Communicate>
{
    public void Configure(EntityTypeBuilder<Communicate> builder)
    {
        builder.ToTable("Communicates", x => x.IsTemporal());
        builder.HasKey(x => x.CommunicateId);
        builder.Property(x => x.CommunicateId).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Scope).IsRequired();
        builder.HasMany(x => x.CommunicateAreas).WithOne(x => x.Communicate).HasForeignKey(x => x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x => x.CommunicateAssets).WithOne(x => x.Communicate).HasForeignKey(x => x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.CommunicateCategories).WithOne(x=>x.Communicate).HasForeignKey(x=>x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.CommunicateCoordinates).WithOne(x=>x.Communicate).HasForeignKey(x=>x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.CommunicateDevices).WithOne(x=>x.Communicate).HasForeignKey(x=>x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.CommunicateModels).WithOne(x=>x.Communicate).HasForeignKey(x=>x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.CommunicateSpaces).WithOne(x=>x.Communicate).HasForeignKey(x=>x.CommunicateId).OnDelete(DeleteBehavior.NoAction);
    }
}
