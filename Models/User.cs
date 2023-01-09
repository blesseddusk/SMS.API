using System;
using System.Collections.Generic;

namespace SMS.API.Models;

public partial class User
{
    public long Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public long RoleId { get; set; }

    public bool IsActive { get; set; }

    public int? LoginAttemptCount { get; set; }

    public DateTime? LoginAttemptTime { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public DateTime? PasswordUpdateTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? UpdatedBy { get; set; }

    public virtual Role Role { get; set; } = null!;
}
