using System.Runtime.Serialization;

namespace ParkCostCalc.Core.Models
{
    public enum ParkTypeEnum
    {
        [EnumMember(Value = "Valet")]
        Valet,
        [EnumMember(Value = "ShortTerm")]
        ShortTerm,
        [EnumMember(Value = "LongTermGarage")]
        LongTermGarage,
        [EnumMember(Value = "LongTermSurface")]
        LongTermSurface,
        [EnumMember(Value = "Economy")]
        Economy
    }
}