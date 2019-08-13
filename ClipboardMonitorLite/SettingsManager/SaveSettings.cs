using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardMonitorLite.SettingsManager
{
    public class HandleSettings
    {
        public async void WriteSettingsFile(string jsonFile, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    await sw.WriteLineAsync(jsonFile);
                }
            }
            catch
            {
                //TODO: CONTINUE!!
            }
        }


    }
}
