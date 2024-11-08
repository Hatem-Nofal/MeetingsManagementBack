using MeetingsManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MeetingsManagement.Permissions;

public class MeetingsManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MeetingsManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MeetingsManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MeetingsManagementResource>(name);
    }
}
