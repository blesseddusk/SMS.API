using System;
using System.Collections.Generic;

namespace SMS.API.Models;

public partial class SubMenu
{
    public long Id { get; set; }

    public string SubMenuId { get; set; } = null!;

    public string? Description { get; set; }

    public string? MainMenuId { get; set; }

    public string? ActionName { get; set; }

    public string? ControllerName { get; set; }

    public int Ordering { get; set; }

    public string? Icon { get; set; }

    public bool IsWeb { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? UpdatedBy { get; set; }
}
