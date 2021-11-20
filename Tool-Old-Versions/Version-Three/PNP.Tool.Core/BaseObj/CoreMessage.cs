using System;
using System.Collections.Generic;
using PNP.Tool.Core.Enums.Modules;

namespace PNP.Tool.Core.BaseObj {
    public class CoreMessage
    {
        /// <summary>
        /// Creates an new Instance of <see cref="CoreMessage"/>
        /// </summary>
        /// <param name="title">The Title for the Message</param>
        /// <param name="description">The Description of the Message</param>
        /// <param name="messageLevel">The Level of the Message</param>
        /// <param name="exception">Possible Exceptions atached to this Message</param>
        public CoreMessage (string title = default, 
                           string description = default, 
                           EnumMessageLevel? messageLevel = null, 
                           List<Exception> exceptions = null)
        {
            //Standard Values
            HasTitle = false;
            HasDescription = false;
            HasExceptions = false;
            Exceptions = new();
            MessageLevel = EnumMessageLevel.Unknown;

            //If other values are given on Constrution, use them
            if (title != default) {
                Title = title;
                HasTitle = true;
            }
            if (description != default) {
                Description = description;
                HasDescription = true;
            }
            if (messageLevel.HasValue) {
                MessageLevel = messageLevel.Value;
            }
            if (exceptions != null && exceptions.Count > 0) {
                Exceptions = exceptions;
                HasExceptions = true;
            }
        }

        public string Title { get; private set; }
        public bool HasTitle { get; private set; }
        public string Description { get; private set; }
        public bool HasDescription { get; private set; }
        public EnumMessageLevel MessageLevel { get; private set; }
        public List<Exception> Exceptions { get; private set; }
        public bool HasExceptions { get; private set; }
    }
}
