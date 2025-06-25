using MySolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MySolution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MySolutionEntityFrameworkCoreModule),
    typeof(MySolutionApplicationContractsModule)
    )]
public class MySolutionDbMigratorModule : AbpModule
{
}
