﻿using Sc3Hosted.Shared.Enumerations;

namespace Sc3Hosted.Shared.Dtos;
public class CommunicateDto
{
    public int CommunicateId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Scope Scope { get; set; }
    public CommunicationType CommunicationType { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool IsArchived { get; set; } = false;
    public List<AreaCommunicateDto> AreaCommunicates { get; set; } = new();
    public List<AssetCommunicateDto> AssetCommunicates { get; set; } = new();
    public List<CoordinateCommunicateDto> CoordinateCommunicates { get; set; } = new();
    public List<DeviceCommunicateDto> DeviceCommunicates { get; set; } = new();
    public List<ModelCommunicateDto> ModelCommunicates { get; set; } = new();
    public List<SpaceCommunicateDto> SpaceCommunicates { get; set; } = new();
}
