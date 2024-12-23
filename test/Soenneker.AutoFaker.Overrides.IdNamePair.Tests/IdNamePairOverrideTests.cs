using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.AutoFaker.Overrides.IdNamePair.Tests;

[Collection("Collection")]
public class IdNamePairOverrideTests : FixturedUnitTest
{
    public IdNamePairOverrideTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
