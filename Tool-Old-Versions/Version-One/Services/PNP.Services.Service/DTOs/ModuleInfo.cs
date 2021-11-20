using PNP.Services.Service.Enumerators;
using System;

namespace PNP.Services.Service.DTOs
{
    public class ModuleInfo
    {
        public ModuleEnum ModuleEnum { get; set; }
        public GameEnum GameEnum { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
    }
}
