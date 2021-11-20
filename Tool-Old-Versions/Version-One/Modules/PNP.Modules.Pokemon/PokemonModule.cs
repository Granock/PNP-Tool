using PNP.Services.Service.DTOs;
using PNP.Services.Service.Enumerators;
using PNP.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PNP.Modules.Pokemon
{
    public class PokemonModule : BaseModule
    {
        #region Constructor
        public PokemonModule(IServiceProvider serviceProvider) : base(serviceProvider)
        {
                
        }
        #endregion

        #region Actions and Funcs
        public override Action Closing { get; set; }
        #endregion

        #region Functions for Form
        public override void FillModuleControlsIn(ref Panel ModulePanel, ref ToolStrip TopMenu, ref StatusStrip BottomMenu)
        {
            //throw new NotImplementedException();
        }
        #endregion

        public override void CloseModule()
        {
            //throw new NotImplementedException();
        }

        public override ModuleInfo GetModuleInfo()
        { return new ModuleInfo(){ GameEnum = GameEnum.Pokemon, ModuleEnum = ModuleEnum.Pokemon, ModuleName = "PokemonModule", ModuleDescription = "Desc" }; }
    }
}
