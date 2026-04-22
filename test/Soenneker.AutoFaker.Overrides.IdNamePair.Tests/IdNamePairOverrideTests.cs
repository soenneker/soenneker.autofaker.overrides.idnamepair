using Soenneker.Tests.HostedUnit;

namespace Soenneker.AutoFaker.Overrides.IdNamePair.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdNamePairOverrideTests : HostedUnitTest
{
    public IdNamePairOverrideTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
