using System.ComponentModel;

namespace PNP.Tool.Core.Enums.Modules
{
    public enum EnumMessageLevel
    {
        [Description("The Severity of the Exception is unknown")]
        Unknown = 2,

        [Description("The Severity warents a normal Message to be shown. Example: a Background-Process was started")]
        Info = 4,

        [Description("The Severity warents a Warning to be shown. Example: an entered value was replaced")]
        Warning = 6,

        [Description("The Severity warents an Error to be shown. Example: a function save/load-func fails completely")]
        Error = 8,

        [Description("The Severity warents a Critical Error to be displayed. Example: a whole Module couldn't start correctly")]
        CriticalError = 10
    }
}
