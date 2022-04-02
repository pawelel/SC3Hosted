﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sc3Hosted.Shared.Dtos;
public class ParameterUpdateDto
{
    public string Name { get; set; }

    public ParameterUpdateDto(string name)
    {
        Name = name;
    }

    public string? Description { get; set; }
}
