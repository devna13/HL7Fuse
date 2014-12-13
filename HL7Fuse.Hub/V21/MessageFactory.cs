﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Fuse.Hub.V21
{
    /// <summary>
    /// Message factory
    /// </summary>
    public class MessageFactory : MessageFactoryBase
    {
        #region Public properties
        public override string Name
        {
            get { return "V21.MessageFactory"; }
        }
        #endregion
    }
}
