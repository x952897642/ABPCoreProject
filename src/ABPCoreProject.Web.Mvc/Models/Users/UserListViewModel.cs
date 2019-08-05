using System.Collections.Generic;
using ABPCoreProject.Roles.Dto;
using ABPCoreProject.Users.Dto;

namespace ABPCoreProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
