using EPS.Application.Common.Enums;
using Microsoft.AspNetCore.Authorization;

namespace EPS.Api.PolicyProvider
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public static string ClaimType => AppClaimTypes.Permissions;

        public PermissionOperator PermissionOperator { get; }

        public string[] Permissions { get; }

        public PermissionRequirement(PermissionOperator permissionOperator, string[] permissions)
        {
            if (permissions.Length == 0)
                //throw new CustomException("At least one permission is required.", StatusCodes.Status403Forbidden);

            PermissionOperator = permissionOperator;
            Permissions = permissions;
        }
    }
}
