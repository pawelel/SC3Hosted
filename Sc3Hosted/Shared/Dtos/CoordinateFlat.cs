﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sc3Hosted.Shared.Dtos;
public class CoordinateFlat
{
    public int CoordinateId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsArchived { get; set; }

}
