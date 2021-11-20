using System;
using System.Drawing;
using PNP.Tool.Core.Enums.Modules;

namespace PNP.Tool.Services.Core.ImageProvider {
    /// <summary>
    /// Provides Images and Bitmaps
    /// </summary>
    public interface IImageProviderService
    {
        #region GetIdentifier-Functions

        /// <summary>
        /// Retrievs the <see cref="Guid"/> for the Module-Picture.
        /// </summary>
        /// <param name="module">The Module for which the <see cref="Image"/> is</param>
        /// <returns>The <see cref="Guid"/> for the Image</returns>
        public Guid GetIdentifierForModule(EnumModule module);

        /// <summary>
        /// Retrievs the <see cref="Guid"/> for the ModuleGroup-Picture.
        /// </summary>
        /// <param name="moduleGrouping">The ModuleGroup for which the <see cref="Image"/> is</param>
        /// <returns>The <see cref="Guid"/> for the Image</returns>
        public Guid GetIdentifierForModuleGrouping(EnumModuleGrouping moduleGrouping);

        /// <summary>
        /// Retrievs the <see cref="Guid"/> for the Icon for a class.
        /// </summary>
        /// <param name="classinstance">The class for which the <see cref="Image"/> is</param>
        /// <returns>The <see cref="Guid"/> for the Image</returns>
        public Guid GetIdentifierForClassIcon<T>(T classinstance);

        /// <summary>
        /// Retrievs the <see cref="Guid"/> for the Name.
        /// </summary>
        /// <param name="Name">The name which identifies the <see cref="Image"/></param>
        /// <returns>The <see cref="Guid"/> for the Image</returns>
        public Guid GetIdentifierByName(string Name);

        #endregion

        #region Retrieval-Functions

        /// <summary>
        /// Checks if Imagedata is available for this <see cref="Guid"/>
        /// </summary>
        /// <param name="Identifier">the <see cref="Guid"/> which has to be checked</param>
        /// <returns>true if data is available, else false</returns>
        public bool HasImage(Guid Identifier);

        /// <summary>
        /// Retrieves the data for the <see cref="Guid"/> and returns it as an <see cref="Image"/>
        /// </summary>
        /// <param name="Identifier">the <see cref="Guid"/> which identifies the data</param>
        /// <returns>the <see cref="Image"/></returns>
        public Image GetImage(Guid Identifier);

        /// <summary>
        /// Retrieves the data for the <see cref="Guid"/> and returns it as an <see cref="Icon"/>
        /// </summary>
        /// <param name="Identifier">the <see cref="Guid"/> which identifies the data</param>
        /// <returns>the <see cref="Icon"/></returns>
        public Icon GetIcon(Guid Identifier);

        /// <summary>
        /// Retrieves the data for the <see cref="Guid"/> and returns it as an <see cref="Bitmap"/>
        /// </summary>
        /// <param name="Identifier">the <see cref="Guid"/> which identifies the data</param>
        /// <returns>the <see cref="Bitmap"/></returns>
        public Bitmap GetBitmap(Guid Identifier);

        #endregion

        #region Save-Functions

        /// <summary>
        /// Deletes the Data for this <see cref="Guid"/>
        /// </summary>
        /// <param name="Identifier">The <see cref="Guid"/> with wich the Data is connected</param>
        /// <returns>if the data has been deleted</returns>
        public bool DeleteData(Guid Identifier);

        /// <summary>
        /// Saves Data for a <see cref="Guid"/>
        /// </summary>
        /// <param name="Identifier">the <see cref="Guid"/></param>
        /// <param name="Payload">The Data</param>
        /// <returns>If the Data was Successfully saved</returns>
        public bool SaveData(Guid Identifier, Image Payload);

        #endregion
    }
}
