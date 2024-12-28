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

### Usage (Bootstrap Framework) as Service

1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/
2. Add ```@using Maurosoft.Blazor.Components``` in your _Imports.razor
3. Add ```builder.Services.AddBlazorSpinnerServices();``` in your Program.cs file
4. Add ```<Spinner IsServiceSpinner="true" SpinnerMode="SpinnerMode.Page" SpinnerLoader="SpinnerLoader.Loader1" Visible="true" />``` to your page file
5. On page you want to call the spinner from, inject the SpinnerService into it: ```@inject SpinnerService _spinnerService```
6. Call ```_spinnerService.Show()``` and ```_spinnerService.Hide()``` to "Show" or "Hide" the spinner.

### Usage (Tailwind Framework) as Service

1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/
2. Add ```@using Maurosoft.Blazor.Components``` in your _Imports.razor
3. Add ```builder.Services.AddBlazorTailwindCoreServices();``` in your Program.cs file
4. Add ```builder.Services.AddBlazorSpinnerServices();``` in your Program.cs file
4. Add ```<Spinner IsServiceSpinner="true" SpinnerMode="SpinnerMode.Page" SpinnerLoader="SpinnerLoader.Loader1" Visible="true" />``` to your page file
5. On page you want to call the spinner from, inject the SpinnerService into it: ```@inject SpinnerService _spinnerService```
6. Call ```_spinnerService.Show()``` or ```_spinnerService.Hide()``` to "Show" or "Hide" the spinner.

### Usage (Tailwind Framework) inside Page
1. Install the library from Nuget: https://www.nuget.org/packages/Maurosoft.Blazor.Components.Spinner/
2. Add ```@using Maurosoft.Blazor.Components``` in your _Imports.razor
3. Add ```builder.Services.AddBlazorTailwindCoreServices();``` in your Program.cs file
4. Add ```builder.Services.AddBlazorSpinnerServices();``` in your Program.cs file
5. Add component in your page
   ```
   ....

   <Spinner @ref="Spinner1" SpinnerLoader="SpinnerLoader.Loader1" Visible="false" />
   <button type="button" @onclick="Click" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2 dark:bg-blue-600 dark:hover:bg-blue-700 focus:outline-none dark:focus:ring-blue-800">Show</button>

   @code {
        Spinner Spinner1 { get; set; } = default!;

        private int _delay = 2000;

        async void Click()
        {
            await Spinner1.ShowAsync(async (callBackFunctionClose) =>
            {
                await Task.Delay(_delay); // Simulates a long activity
                await callBackFunctionClose(); // Invokes the asynchronous closing routine
            });
        }
   }
   ```

### Requirements
- **.NET 8.0** or **.NET 9.0**

### Contributing
Contributions, bug reports, and feature requests are welcome! To contribute:
1. Fork the repository.
2. Create a new branch for your changes.
3. Submit a pull request for review.

### License
Distributed under the MIT License. See the [LICENSE](LICENSE) file for more details.
