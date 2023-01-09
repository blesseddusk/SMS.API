using System;
using System.Collections.Generic;

namespace SMS.API.Models;

public partial class MainMenu
{
    public long Id { get; set; }

    public string MainMenuId { get; set; } = null!;

    public string? Description { get; set; }

    public int? Ordering { get; set; }

    public string? Icon { get; set; }

    public long IsWeb { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? UpdatedBy { get; set; }
}
