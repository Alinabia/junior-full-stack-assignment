using System;
using LeanTask.Domain.Contracts;
using Microsoft.AspNetCore.Identity;

namespace LeanTask.Infrastructure.Models.Identity
{
    public class LeanRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual LeanRole Role { get; set; }

        public LeanRoleClaim() : base()
        {
        }

        public LeanRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}