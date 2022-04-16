﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class AssetSituationConfig : IEntityTypeConfiguration<AssetSituation>
{
    public void Configure(EntityTypeBuilder<AssetSituation> builder)
    {
        builder.ToTable("AssetSituations", x => x.IsTemporal());
        builder.HasKey(x => new { x.AssetId, x.SituationId });
        builder.Property(x => x.AssetId).IsRequired();
        builder.Property(x => x.SituationId).IsRequired();
        builder.HasOne(x => x.Asset).WithMany(x => x.AssetSituations).HasForeignKey(x => x.AssetId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Situation).WithMany(x => x.AssetSituations).HasForeignKey(x => x.SituationId).OnDelete(DeleteBehavior.Restrict);
    }
}
