using PNP.Tool.Updating.Updaters;

namespace PNP.Tool.Updating {
    public class UpdaterFactory
    {
        public IUpdater GetUpdater()
        {
            return new BaseUpdater();
        }
    }
}
