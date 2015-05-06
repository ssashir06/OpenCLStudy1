using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloo;

namespace ConsoleApplication1
{
    class ClooClass
    {
        public void Init()
        {
            var platforms = ComputePlatform.Platforms;
            foreach (var platform in platforms)
            {
                Console.WriteLine("Platform: {0} ({1})", platform.Name, platform.Version);
                Console.WriteLine("Number of Devices: {0}", platform.Devices.Count);
            }
        }
    }
}
