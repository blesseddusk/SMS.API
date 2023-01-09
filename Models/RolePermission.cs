using System;
using System.Collections.Generic;

namespace SMS.API.Models;

public partial class RolePermission
{
    public long Id { get; set; }

    public long RoleId { get; set; }

    public string SubMenuId { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsAdd { get; set; }

    public bool IsEdit { get; set; }

    public bool IsDelete { get; set; }

    public bool IsWeb { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? UpdatedBy { get; set; }

    public virtual Role Role { get; set; } = null!;
}
