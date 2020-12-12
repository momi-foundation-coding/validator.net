## Welcome to .NET String Validator

*Port of [@chriso](https://github.com/chriso)'s library, [validator.js](https://github.com/validatorjs/validator.js)*

*First Developed by [@Alex](https://github.com/AlexArchive), former repo [Validator](https://github.com/AlexArchive/Validator)*

*Then, Developed by [@ezkemboi](https://github.com/ezkemboi)*

## Installation


Validator is [available on NuGet](https://www.nuget.org/packages/StringValidator):

Package Manager: ```Install-Package StringValidator```

.NET CLI: ```dotnet add package StringValidator```

Package Reference: ```<PackageReference Include="StringValidator" />```

Paket CLI: ```paket add StringValidator```

## Usage Example

An Example on how to make use of StringValidator

```c#
// make sure StringValidator is added as a package. Check Above for Installation
using System;

namespace Example 
{
  public class Example 
  {
    static bool IsValidEmail(string email) {
      var validEmail = Validator.IsEmail(email);
      return validEmail;
    }
  }
}
```

For more validation see [Supported validation](https://github.com/ezkemboi/validator.net/blob/master/Readme.md).


## Support or Contact

Having trouble with Usage of `StringValidator?` Please [raise issue](https://github.com/ezkemboi/validator.net/issues/new) and we’ll help you sort it out.
