using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace MySolution.Settings;

public class MySolutionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(new SettingDefinition(
        "Abp.Localization.DefaultLanguage",
        "ar",
        LocalizableString.Create("DisplayName:Abp.Localization.DefaultLanguage"),
        LocalizableString.Create("Description:Abp.Localization.DefaultLanguage"),
        isVisibleToClients: true,
        isInherited: true,
        isEncrypted: false));
    }
}
