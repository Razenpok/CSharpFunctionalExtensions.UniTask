CSharpFunctionalExtensions.UniTask
======================================================

UniTask extensions for [CSharpFunctionalExtensions][]

## Installation

There are several ways to install this library into our project:

- **Clone source code**: Clone or [download][] this repository and put the *src/CSharpFunctionalExtensions.UniTask*
  folder somewhere in your Unity project
- **Unity Package Manager (UPM)**: Add the following line to *Packages/manifest.json*:
  - `"ext.csharpfunctionalextensions.unitask": "https://github.com/Razenpok/CSharpFunctionalExtensions.UniTask.git?path=src/CSharpFunctionalExtensions.UniTask",`
- **[OpenUPM][]**: After installing [openupm-cli][], run the following command:
  - `openupm add ext.csharpfunctionalextensions.unitask`

You will also need to obtain a compatible version of CSharpFunctionalExtensions library (**major** version must match
with CSharpFunctionalExtensions.UniTask):

- **NuGet**: Download a .nupkg file from [NuGet registry][], change the file extension to .zip, unzip it,
  find the .dll file in *lib/netstandard2.0* folder
- **[UnityNuGet registry][]**: please vote for [this issue][] so the package will be available in this registry
- **[NuGetForUnity plugin][]**

[//]: # (Links)

[download]: https://github.com/Razenpok/CSharpFunctionalExtensions.UniTask/archive/master.zip
[OpenUPM]: https://openupm.com
[openupm-cli]: https://github.com/openupm/openupm-cli
[NuGet registry]: https://www.nuget.org/packages/CSharpFunctionalExtensions/
[UnityNuGet registry]: https://github.com/xoofx/UnityNuGet
[this issue]: https://github.com/xoofx/UnityNuGet/pull/179
[NuGetForUnity plugin]: https://github.com/GlitchEnzo/NuGetForUnity

## Usage

You can find the extensive set of usage examples in the [CSharpFunctionalExtensions repository][CSharpFunctionalExtensions]

Here is a short primer if you are not familiar with this library

### Get rid of primitive obsession

```csharp
Result<CustomerName> name = CustomerName.Create(model.Name);
Result<Email> email = Email.Create(model.PrimaryEmail);

Result result = Result.Combine(name, email);
if (result.IsFailure)
    return Error(result.Error);

var customer = new Customer(name.Value, email.Value);
```

### Make nulls explicit with the Maybe type

```csharp
Maybe<Customer> customerOrNothing = _customerRepository.GetById(id);
if (customerOrNothing.HasNoValue)
    return Error("Customer with such Id is not found: " + id);
```

### Compose multiple operations in a single chain

```csharp
return _customerRepository.GetById(id)
    .ToResult("Customer with such Id is not found: " + id)
    .Ensure(customer => customer.CanBePromoted(), "The customer has the highest status possible")
    .Tap(customer => customer.Promote())
    .Tap(customer => _emailGateway.SendPromotionNotification(customer.PrimaryEmail, customer.Status))
    .Finally(result => result.IsSuccess ? Ok() : Error(result.Error));
```

[//]: # (Global Links)

[CSharpFunctionalExtensions]: https://github.com/vkhorikov/CSharpFunctionalExtensions