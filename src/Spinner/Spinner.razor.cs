using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Maurosoft.Blazor.Tailwind.Core;
using Maurosoft.Blazor.Tailwind.Core.Css;
using Maurosoft.Blazor.Tailwind.Core.Enums;
using Microsoft.AspNetCore.Components;

namespace Maurosoft.Blazor.Components.Spinner;

public partial class Spinner : BlazorComponentBase
{
    protected string baseClass { get; private set; } = "visible";
    protected bool _stateChanged = false;

    protected override bool ShouldAutoGenerateId => true;

    protected override string IdSuffix => "spinner-";

    protected override void OnInitializeCssProperties()
    {

    }

    protected override void OnGenerateCssClasses()
    {

    }

    /// <summary>
    /// Set the spinner mode:
    ///- Alone
    ///- Page: is displayed within the page
    ///- Element: is displayed within the element containing it
    /// </summary>
    [Parameter]
    public SpinnerMode SpinnerMode { get; set; } = SpinnerMode.Alone;

    /// <summary>
    /// Set the loader to be displayed, choosing from those available
    /// </summary>
    [Parameter]
    public SpinnerLoader SpinnerLoader { get; set; } = SpinnerLoader.Loader1;

    /// <summary>
    /// Set the background colour of the element where the spinner is contained (see Spinner Mode)
    /// </summary>
    [Parameter]
    public ColorRgb SpinnerBackgroundColor { get; set; } = ColorRgb.Gray_200;

    /// <summary>
    /// Set the background opacity of the element where the spinner is contained (see Spinner Mode)
    /// </summary>
    [Parameter]
    public SpinnerBackgroundOpacity SpinnerBackgroundOpacity { get; set; } = SpinnerBackgroundOpacity.None;

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public ColorRgb SpinnerColorLite { get; set; } = ColorRgb.Gray_600;

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public ColorRgb SpinnerColorBrand { get; set; } = ColorRgb.Red_600;

    /// <summary>
    /// 
    /// </summary>
    [Parameter]
    public ColorRgb SpinnerColorBase { get; set; } = ColorRgb.Blue_600;

    /// <summary>
    /// Set the width and height of the spinner
    /// </summary>
    [Parameter]
    public SpinnerSize SpinnerSize { get; set; } = SpinnerSize.px32;

    /// <summary>
    /// Sets the horizontal position of the spinner within the element
    /// </summary>
    [Parameter]
    public SpinnerHorizontalPosition SpinnerHorizontalPosition { get; set; } = SpinnerHorizontalPosition.Center;

    /// <summary>
    /// Sets the vertical position of the spinner within the element
    /// </summary>
    [Parameter]
    public SpinnerVerticalPosition SpinnerVerticalPosition { get; set; } = SpinnerVerticalPosition.Middle;

    /// <summary>
    /// Indicates whether the spinner is related to a spinner service or not.
    /// </summary>
    /// <remarks>
    /// Default value is false.
    /// </remarks>
    [Parameter]
    public bool IsServiceSpinner { get; set; } = false;

    [Inject]
    private SpinnerService SpinnerService { get; set; } = default!;

    /// <summary>
    /// Show the Loader
    /// </summary>
    public void Show()
    {
        baseClass = "visible";
        Visible = true;
        InvokeAsync(() => StateHasChanged());
    }

    /// <summary>
    /// Displays the loader, calls <paramref name="callbackFunction">your function</paramref> and on completion hides the loader (if called within your function)
    /// </summary>
    /// <example>
    /// await Spinner1.ShowAsync(async (callBackFunctionClose) =>
    /// {
    ///   await Task.Delay(2000); // Simulates a long activity
    ///   await callBackFunctionClose(); // Invokes the asynchronous closing routine
    /// });
    /// </example>
    /// <param name="callbackFunction"></param>
    /// <returns></returns>
    public async Task ShowAsync(Func<Func<Task>, Task> callbackFunction)
    {
        async Task hideAfterExexuteWork()
        {
            await Task.Delay(100);
            Hide();
        }

        if (callbackFunction != null)
        {
            // Show spinner
            Show();
            await Task.Delay(100);

            await callbackFunction(hideAfterExexuteWork);
        }
    }

    /// <summary>
    /// Hide the Loader
    /// </summary>
    public void Hide()
    {
        // Hide loader
        baseClass = "invisible";
        Visible = false;
        InvokeAsync(() => StateHasChanged());
    }

    public void SetSpinnerBackgroundColor(ColorRgb backgroundColor) => SpinnerBackgroundColor = backgroundColor;

    public void SetSpinnerBackgroundOpacity(SpinnerBackgroundOpacity backgroundOpacity) => SpinnerBackgroundOpacity = backgroundOpacity;

    public void SetSpinnerLoader(SpinnerLoader spinnerLoader) => SpinnerLoader = spinnerLoader;

    public void SetSpinnerMode(SpinnerMode spinnerMode) => SpinnerMode = spinnerMode;

    public void SetSpinnerHorizontalPosition(SpinnerHorizontalPosition spinnerHorizontalPosition) => SpinnerHorizontalPosition = spinnerHorizontalPosition;

    public void SetSpinnerVerticalPosition(SpinnerVerticalPosition spinnerVerticalPosition) => SpinnerVerticalPosition = spinnerVerticalPosition;

    protected override void OnInitialized()
    {
        if (SpinnerService != null && IsServiceSpinner)
        {
            SpinnerService.OnShow += Show;
            SpinnerService.OnShowCallback += ShowAsync;
            SpinnerService.OnHide += Hide;
        }

        base.OnInitialized();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (SpinnerService != null && IsServiceSpinner)
            {
                SpinnerService.OnShow -= Show;
                SpinnerService.OnShowCallback -= ShowAsync;
                SpinnerService.OnHide -= Hide;
            }
        }

        base.Dispose(disposing);
    }
}
