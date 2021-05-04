using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LEAKSCITY_Auth.Helpers
{
    class HWID
    {
        public string getHWID()
        {
            using (var objs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor"))
            {
                var HWID = string.Empty;
                foreach (var obj in objs.Get())
                {
                    HWID = obj["ProcessorId"].ToString();
                    break;
                }
                return HWID;
            }
        }
    }
}
