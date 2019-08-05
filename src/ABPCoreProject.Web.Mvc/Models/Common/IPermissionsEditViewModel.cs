using System.Collections.Generic;
using ABPCoreProject.Roles.Dto;

namespace ABPCoreProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}