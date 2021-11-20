using PNP.Tool.Databases.Base;

namespace PNP.Tool.Services.Base {
    public abstract class BaseService {

        protected abstract DbEnum GetDBEnum();

        protected BaseContext GetDatabase() {
            return DatabaseProvider.GetDatabase(GetDBEnum());
        }
    
    }
}
