using MySolution.Samples;
using Xunit;

namespace MySolution.EntityFrameworkCore.Domains;

[Collection(MySolutionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MySolutionEntityFrameworkCoreTestModule>
{

}
