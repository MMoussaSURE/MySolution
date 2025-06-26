using MySolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MySolution.Permissions;

public class MySolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MySolutionPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MySolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MySolutionResource>(name);
    }
}
