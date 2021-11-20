namespace PNP.Tool.Core.Enums.Modules
{
    public static class EnumExtensions
    {
        public static string ToReadableString(this EnumModuleGrouping Group)
        {
            return Group switch {
                EnumModuleGrouping.None => "Andere",
                EnumModuleGrouping.DSA4_1 => "DSA 4.1",
                EnumModuleGrouping.SR4 => "Shadowrun 4",
                EnumModuleGrouping.Pokemon => "Pokemon",
                _ => "Andere",
            };
        }
    }
}
