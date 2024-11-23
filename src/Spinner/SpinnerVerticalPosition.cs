using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public enum SpinnerVerticalPosition
{
    [EnumMember(Value = "flex-start")]
    Top = 1,
    [EnumMember(Value = "center")]
    Middle = 2,
    [EnumMember(Value = "flex-end")]
    Bottom = 3,
}
