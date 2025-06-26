using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MySolution.Data;

/* This is used if database provider does't define
 * IMySolutionDbSchemaMigrator implementation.
 */
public class NullMySolutionDbSchemaMigrator : IMySolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
