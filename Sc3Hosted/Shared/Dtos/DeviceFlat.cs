﻿namespace Sc3Hosted.Shared.Dtos;
public class DeviceFlat : BaseDto
{
    public int DeviceId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
