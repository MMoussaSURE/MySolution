using Microsoft.Extensions.Localization;
using MySolution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MySolution;

[Dependency(ReplaceServices = true)]
public class MySolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MySolutionResource> _localizer;

    public MySolutionBrandingProvider(IStringLocalizer<MySolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
