using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNMyFancyLib
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMyFancyLibModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMyFancyLibModule"/>.
        /// </summary>
        internal RNMyFancyLibModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMyFancyLib";
            }
        }
    }
}
