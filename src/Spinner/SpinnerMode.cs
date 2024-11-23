using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public enum SpinnerMode
{
    [EnumMember(Value = "alone")]
    Alone,
    [EnumMember(Value = "page")]
    Page,
    [EnumMember(Value = "element")]
    Element
}
