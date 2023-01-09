using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Sims3ConfigMaker
{
    public class SystemInfo
    {
        public string ReadGPUInfo()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    Console.WriteLine("Memory: " + (Double.Parse(obj["AdapterRAM"].ToString()) / Math.Pow(1024, 2)));
                    Console.WriteLine("Description: " + obj["Description"].ToString());
                }
            }

            return "";
        }


    }
}
