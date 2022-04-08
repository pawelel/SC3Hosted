﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Sc3Hosted.Server.Entities;

namespace Sc3Hosted.Server.Data.Configurations;

public class CommunicateCategoryConfig : IEntityTypeConfiguration<CommunicateCategory>
{
    public void Configure(EntityTypeBuilder<CommunicateCategory> builder)
    {
        builder.ToTable("CommunicateCategories", x => x.IsTemporal());
        builder.HasKey(x => x.CommunicateCategoryId);
        builder.Property(x => x.CommunicateCategoryId).ValueGeneratedOnAdd();
        builder.Property(x => x.CommunicateId).IsRequired();
        builder.Property(x => x.CategoryId).IsRequired();
    }
}
