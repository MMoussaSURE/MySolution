using Volo.Abp.Modularity;

namespace MySolution;

[DependsOn(
    typeof(MySolutionApplicationModule),
    typeof(MySolutionDomainTestModule)
)]
public class MySolutionApplicationTestModule : AbpModule
{

}
