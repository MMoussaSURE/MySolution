using System.Threading.Tasks;

namespace MySolution.Data;

public interface IMySolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
