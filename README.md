# Blazor Spinner

[![NuGet Downloads](https://img.shields.io/nuget/dt/Maurosoft.Blazor.Components.Spinner)](https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/)

Blazor Spinner is a beautiful loading spinner that can be included in your Blazor applications.

![Blazor Spinner Preview](https://s11.gifyu.com/images/Sye7L.gif)

![Blazor Spinner Preview](https://s11.gifyu.com/images/Sye7D.gif)

[Live Demo](https://demoblazorspinnertailwind-eqcza4a6gve7dscx.italynorth-01.azurewebsites.net/)

### Features

- High level of customisation;
- Over 80 loaders;
- Pure Css;
- 3 modes of operation: alone, within an element, page;
- Independent of the css framework used (Bootstrap or Tailwind)

### Packages

|           | Stable Package |
| --------- | -------------- |
| Spinner   | [![NuGet Version](https://img.shields.io/nuget/v/Maurosoft.Blazor.Components.Spinner)](https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/)|

### Usage (Bootstrap Framework)

1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/
2. Add ```@using Maurosoft.Blazor.Components``` in your _Imports.razor
4. Add ```builder.Services.AddBlazorSpinnerServices();``` in your Program.cs file
4. Add ```<Spinner IsServiceSpinner="true" SpinnerMode="SpinnerMode.Page" SpinnerLoader="SpinnerLoader.Loader1" Visible="true" />``` to your page file
5. On page you want to call the spinner from, inject the SpinnerService into it: ```@inject SpinnerService _spinnerService```
6. Call ```_spinnerService.Show()``` and ```_spinnerService.Hide()``` to "Show" or "Hide" the spinner.

### Usage (Tailwind Framework)

1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/
2. Add ```@using Maurosoft.Blazor.Components``` in your _Imports.razor
3. Add ```builder.Services.AddBlazorTailwindCoreServices();``` in your Program.cs file
4. Add ```builder.Services.AddBlazorSpinnerServices();``` in your Program.cs file
4. Add ```<Spinner IsServiceSpinner="true" SpinnerMode="SpinnerMode.Page" SpinnerLoader="SpinnerLoader.Loader1" Visible="true" />``` to your page file
5. On page you want to call the spinner from, inject the SpinnerService into it: ```@inject SpinnerService _spinnerService```
6. Call ```_spinnerService.Show()``` or ```_spinnerService.Hide()``` to "Show" or "Hide" the spinner.


### Requirements
- **.NET 8.0** or **.NET 9.0**

### Contributing
Contributions, bug reports, and feature requests are welcome! To contribute:
1. Fork the repository.
2. Create a new branch for your changes.
3. Submit a pull request for review.

### License
Distributed under the MIT License. See the [LICENSE](LICENSE) file for more details.
