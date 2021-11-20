using Microsoft.Extensions.DependencyInjection;
using PNP.Services.Service.DTOs;
using System;
using System.Windows.Forms;

namespace PNP.Services.Service.Interfaces
{
    public abstract class BaseModule
    {
        #region BaseClass Only
        private readonly IServiceProvider _ServiceProvider;
        public T GetService<T>()
            => _ServiceProvider.GetRequiredService<T>();
        #endregion

        #region Constructor
        public BaseModule(IServiceProvider serviceProvider)
        { _ServiceProvider = serviceProvider; }
        #endregion

        #region Actions and Funcs
        public abstract Action Closing { get; set; }
        #endregion

        #region Functions for Forms
        public abstract void FillModuleControlsIn(ref Panel ModulePanel, ref ToolStrip TopMenu, ref StatusStrip BottomMenu);
        #endregion

        public abstract void CloseModule();
        public abstract ModuleInfo GetModuleInfo();
    }
}
