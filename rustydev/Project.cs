using rustydev.Data.Models;
using System;
using System.Collections.Generic;

namespace rustydev;

public partial class Project
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Details { get; set; }

    public string? GitHubLink { get; set; }

    public string? ImagePath { get; set; }

    public int CategoryId { get; set; }

    public virtual ProjectCategory Category { get; set; } = null!;

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
