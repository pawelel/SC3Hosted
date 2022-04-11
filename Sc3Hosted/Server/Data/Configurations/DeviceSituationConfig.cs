﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Sc3Hosted.Server.Entities;

namespace Sc3Hosted.Server.Data.Configurations;

public class DeviceSituationConfig : IEntityTypeConfiguration<DeviceSituation>
{
    public void Configure(EntityTypeBuilder<DeviceSituation> builder)
    {
        builder.ToTable("DeviceSituations", x => x.IsTemporal());
        builder.HasKey(x => new{x.DeviceId, x.SituationId});
        builder.Property(x => x.SituationId).IsRequired();
        builder.Property(x => x.DeviceId).IsRequired();
    }
}