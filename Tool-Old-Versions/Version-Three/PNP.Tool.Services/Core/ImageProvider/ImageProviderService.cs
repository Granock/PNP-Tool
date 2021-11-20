using System;
using System.Drawing;
using PNP.Tool.Core.Enums.Modules;

namespace PNP.Tool.Services.Core.ImageProvider {
    public class ImageProviderService : CoreService, IImageProviderService {    


        #region Get-Guid-Functions

        public Guid GetIdentifierByName(string Name) {
            //TODO
            return Guid.Empty;
        }

        public Guid GetIdentifierForClassIcon<T>(T classinstance) {
            //TODO
            return Guid.Empty;
        }

        public Guid GetIdentifierForModule(EnumModule module) {
            //TODO
            return Guid.Empty;
        }

        public Guid GetIdentifierForModuleGrouping(EnumModuleGrouping moduleGrouping) {
            //TODO
            return Guid.Empty;
        }

        #endregion

        #region Get-Data-Functions 

        public Image GetImage(Guid Identifier) {
            //TODO
            return null;
        }

        public Bitmap GetBitmap(Guid Identifier) {
            //TODO
            return null;
        }

        public Icon GetIcon(Guid Identifier) {
            //TODO
            return null;
        }

        #endregion

        #region Db-Save/Delete-Functions

        public bool DeleteData(Guid Identifier) {
            //TODO
            return false;
        }

        public bool SaveData(Guid Identifier, Image Payload) {
            //TODO
            return false;
        }

        #endregion

        public bool HasImage(Guid Identifier) {
            //TODO
            return false;
        }
    }
}
