﻿namespace Sc3Hosted.Shared.Dtos;
public class CoordinateUpdateDto
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public virtual List<CommunicateCoordinateDto> CommunicateCoordinates { get; set; } = new();
}
