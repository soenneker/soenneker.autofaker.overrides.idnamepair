[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.idnamepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.idnamepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.idnamepair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.idnamepair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.idnamepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.idnamepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.idnamepair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.idnamepair/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.IdNamePair

An AutoFaker override for generating useful `IdNamePair` fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.IdNamePair
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.IdNamePair;
using Soenneker.Dtos.IdNamePair;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new IdNamePairOverride()];

IdNamePair pair = autoFaker.Generate<IdNamePair>();
```

`Id` is a GUID string and `Name` is a generated company name. The override matches `IdNamePair` itself; it does not opt derived types into the same behavior.
