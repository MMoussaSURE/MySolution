using Volo.Abp.Modularity;

namespace MySolution;

[DependsOn(
    typeof(MySolutionDomainModule),
    typeof(MySolutionTestBaseModule)
)]
public class MySolutionDomainTestModule : AbpModule
{

}
