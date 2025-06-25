using Xunit;

namespace MySolution.EntityFrameworkCore;

[CollectionDefinition(MySolutionTestConsts.CollectionDefinitionName)]
public class MySolutionEntityFrameworkCoreCollection : ICollectionFixture<MySolutionEntityFrameworkCoreFixture>
{

}
