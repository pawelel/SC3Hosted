﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Sc3Hosted.Server.Entities;

namespace Sc3Hosted.Server.Data.Configurations;

public class SituationDetailConfig : IEntityTypeConfiguration<SituationDetail>
{
    public void Configure(EntityTypeBuilder<SituationDetail> builder)
    {
        builder.ToTable("SituationDetails", x => x.IsTemporal());

    }
}