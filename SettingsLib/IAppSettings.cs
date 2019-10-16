using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

//Organize namespaces and keep them consistent, ClipboardMonitorLite.Settings instead of SettingsLib

namespace SettingsLib
{
    public interface IAppSettings
    {
        string Type { get; }
    }
}
