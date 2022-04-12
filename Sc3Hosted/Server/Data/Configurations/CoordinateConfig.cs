﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class CoordinateConfig : IEntityTypeConfiguration<Coordinate>
{
    public void Configure(EntityTypeBuilder<Coordinate> builder)
    {
        builder.ToTable("Coordinates", x => x.IsTemporal());
        builder.HasKey(x => x.CoordinateId);
        builder.Property(x => x.CoordinateId).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(500);
        builder.Property(x => x.SpaceId).IsRequired();
        builder.HasOne(x=>x.Space).WithMany(x=>x.Coordinates).HasForeignKey(x=>x.SpaceId).OnDelete(DeleteBehavior.ClientCascade);
        builder.HasMany(x=>x.CommunicateCoordinates).WithOne(x=>x.Coordinate).HasForeignKey(x=>x.CoordinateId).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(x=>x.Assets).WithOne(x=>x.Coordinate).HasForeignKey(x=>x.CoordinateId).OnDelete(DeleteBehavior.NoAction);
    }
}
