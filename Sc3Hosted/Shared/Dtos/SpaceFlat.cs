﻿using Sc3Hosted.Shared.Enumerations;

namespace Sc3Hosted.Shared.Dtos;

public class SpaceFlat
{

    public bool IsArchived { get; set; }
    public string Name { get; set; } = string.Empty;
    public int SpaceId { get; set; }
    public SpaceType SpaceType { get; set; }

}