using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public enum SpinnerHorizontalPosition
{
    [EnumMember(Value = "left")]
    Left = 1,
    [EnumMember(Value = "center")]
    Center = 2,
    [EnumMember(Value = "right")]
    Right = 3,
}
