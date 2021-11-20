using Microsoft.Extensions.DependencyInjection;

namespace PNP.Tool.Core.Global
{
    public interface IDPInjectionRegister
    {
        /// <summary>
        /// Registers Services in a Collection
        /// </summary>
        /// <param name="serviceCollection">The Collection, where the Services are registered</param>
        public void Register(IServiceCollection serviceCollection);
    }
}
