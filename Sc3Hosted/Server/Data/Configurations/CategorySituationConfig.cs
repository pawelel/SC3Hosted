﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sc3Hosted.Server.Entities;
namespace Sc3Hosted.Server.Data.Configurations;
public class CategorySituationConfig : IEntityTypeConfiguration<CategorySituation>
{
    public void Configure(EntityTypeBuilder<CategorySituation> builder)
    {
        builder.ToTable("CategorySituations", x => x.IsTemporal());
        builder.HasKey(x => new { x.CategoryId, x.SituationId });
        builder.Property(x => x.SituationId).IsRequired();
        builder.Property(x => x.CategoryId).IsRequired();
        builder.HasOne(x => x.Category).WithMany(x => x.CategorySituations).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Situation).WithMany(x => x.CategorySituations).HasForeignKey(x => x.SituationId).OnDelete(DeleteBehavior.Restrict);
    }
}
