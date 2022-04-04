﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Sc3Hosted.Server.Entities;

namespace Sc3Hosted.Server.Data.Configurations;
public class CommunicateAssetConfig : IEntityTypeConfiguration<CommunicateAsset>
{
    public void Configure(EntityTypeBuilder<CommunicateAsset> builder)
    {
        builder.ToTable("CommunicateAssets", x => x.IsTemporal());
        builder.HasKey(x => x.CommunicateAssetId);
        builder.Property(x => x.CommunicateAssetId).ValueGeneratedOnAdd();
        builder.Property(x => x.AssetId).IsRequired();
        builder.Property(x => x.CommunicateId).IsRequired();
    }
}
