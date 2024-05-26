using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.IdNamePair;

/// <summary>
/// An AutoFaker (AutoBogus) override for the DTO IdNamePair
/// </summary>
public class IdNamePairOverride : AutoFakerOverride<Dtos.IdNamePair.IdNamePair>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Dtos.IdNamePair.IdNamePair)!;

        target.Id = context.Faker.Random.Guid().ToString();
        target.Name = context.Faker.Company.CompanyName();
    }
}
