﻿using Sc3Hosted.Shared.Enumerations;
namespace Sc3Hosted.Shared.Dtos;
public class CommunicateWithAssetsDto : BaseDto
{
    public int CommunicateId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Scope Scope { get; set; }
    public CommunicationType CommunicationType { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public virtual List<AssetDto> Assets { get; set; } = new();
}
