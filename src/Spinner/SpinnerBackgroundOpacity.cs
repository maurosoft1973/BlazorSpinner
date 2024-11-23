using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public enum SpinnerBackgroundOpacity
{
    [EnumMember(Value = "1.0")]
    None,
    [EnumMember(Value = "0.9")]
    Opacity90,
    [EnumMember(Value = "0.8")]
    Opacity80,
    [EnumMember(Value = "0.7")]
    Opacity70,
    [EnumMember(Value = "0.6")]
    Opacity60,
    [EnumMember(Value = "0.5")]
    Opacity50,
    [EnumMember(Value = "0.4")]
    Opacity40,
    [EnumMember(Value = "0.3")]
    Opacity30,
    [EnumMember(Value = "0.2")]
    Opacity20,
    [EnumMember(Value = "0.1")]
    Opacity10,
    [EnumMember(Value = "0.0")]
    Opacity0,
}
