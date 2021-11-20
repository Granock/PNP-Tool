using PNP.Modules.Pokemon;
using PNP.Services.Service.DTOs;
using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PNP.Services.Core
{
    public static class GlobalModuleProvider
    {
        private static readonly Dictionary<ModuleEnum, BaseModule> _ModuleList = new Dictionary<ModuleEnum, BaseModule>();

        static GlobalModuleProvider()
        {
            IServiceProvider sp = GlobalServiceProvider.GetServiceProvider();
            RegisterModule(new PokemonModule(sp));
        }

        public static List<ModuleInfo> GetAvailableModules()
        { return _ModuleList.Select(x => x.Value.GetModuleInfo()).ToList(); }

        public static BaseModule GetModule(ModuleEnum Module)
        { return _ModuleList.First(x => x.Key == Module).Value; }

        public static void RegisterModule(BaseModule module)
        { _ModuleList.Add(module.GetModuleInfo().ModuleEnum,module); }
    }
}
