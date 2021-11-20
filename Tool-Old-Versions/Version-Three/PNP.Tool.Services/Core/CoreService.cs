using PNP.Tool.Databases.Base;
using PNP.Tool.Services.Base;

namespace PNP.Tool.Services.Core {
    public abstract class CoreService : BaseService {
        protected override DbEnum GetDBEnum()
            => DbEnum.Core;
    }
}
