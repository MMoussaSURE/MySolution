using MySolution.Samples;
using Xunit;

namespace MySolution.EntityFrameworkCore.Applications;

[Collection(MySolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MySolutionEntityFrameworkCoreTestModule>
{

}
