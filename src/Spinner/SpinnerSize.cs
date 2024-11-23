using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Components.Spinner;

public enum SpinnerSize
{
    [EnumMember(Value = "10px")]
    px10,
    [EnumMember(Value = "11px")]
    px11,
    [EnumMember(Value = "12px")]
    px12,
    [EnumMember(Value = "13px")]
    px13,
    [EnumMember(Value = "14px")]
    px14,
    [EnumMember(Value = "16px")]
    px16,
    [EnumMember(Value = "18px")]
    px18,
    [EnumMember(Value = "20px")]
    px20,
    [EnumMember(Value = "24px")]
    px24,
    [EnumMember(Value = "28px")]
    px28,
    [EnumMember(Value = "32px")]
    px32,
    [EnumMember(Value = "36px")]
    px36,
    [EnumMember(Value = "40px")]
    px40,
    [EnumMember(Value = "48px")]
    px48,
    [EnumMember(Value = "52px")]
    px52,
    [EnumMember(Value = "56px")]
    px56,
    [EnumMember(Value = "60px")]
    px60,
    [EnumMember(Value = "64px")]
    px64,
    [EnumMember(Value = "72px")]
    px72,
    [EnumMember(Value = "80px")]
    px80,
    [EnumMember(Value = "96px")]
    px96,
    [EnumMember(Value = "128px")]
    px128,
    [EnumMember(Value = "256px")]
    px256,
    [EnumMember(Value = "512px")]
    px512
}
