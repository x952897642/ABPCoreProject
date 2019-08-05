using System.Collections.Generic;
using System.Linq;
using ABPCoreProject.Roles.Dto;
using ABPCoreProject.Users.Dto;

namespace ABPCoreProject.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
