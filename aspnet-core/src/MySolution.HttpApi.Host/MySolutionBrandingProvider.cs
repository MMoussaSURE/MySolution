using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MySolution;

[Dependency(ReplaceServices = true)]
public class MySolutionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MySolution";
}
