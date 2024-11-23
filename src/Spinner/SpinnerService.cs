using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public class SpinnerService
{
    internal event Action OnShow = default!;
    internal event Func<Func<Func<Task>, Task>, Task?> OnShowCallback = default!;
    internal event Action? OnHide = default!;

    public void Show() => OnShow?.Invoke();

    public Task? Show(Func<Func<Task>, Task> callbackFunction) => OnShowCallback?.Invoke(callbackFunction);

    public void Hide() => OnHide?.Invoke();
}
