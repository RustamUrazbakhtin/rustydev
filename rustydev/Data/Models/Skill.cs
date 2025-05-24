﻿using System;
using System.Collections.Generic;

namespace rustydev.Data.Models;

public partial class Skill
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? IconPath { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
