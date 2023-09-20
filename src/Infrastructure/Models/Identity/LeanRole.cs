using System;
using System.Collections.Generic;
using LeanTask.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace LeanTask.Infrastructure.Models.Identity
{
    public class LeanRole : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<LeanRoleClaim> RoleClaims { get; set; }

        public LeanRole() : base()
        {
            RoleClaims = new HashSet<LeanRoleClaim>();
        }

        public LeanRole(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<LeanRoleClaim>();
            Description = roleDescription;
        }
    }
}