using Volo.Abp.Modularity;

namespace MySolution;

/* Inherit from this class for your domain layer tests. */
public abstract class MySolutionDomainTestBase<TStartupModule> : MySolutionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
