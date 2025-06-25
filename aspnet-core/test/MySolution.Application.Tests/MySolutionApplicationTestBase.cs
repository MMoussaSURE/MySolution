using Volo.Abp.Modularity;

namespace MySolution;

public abstract class MySolutionApplicationTestBase<TStartupModule> : MySolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
