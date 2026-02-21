using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.StorageProblem
{
    public class LocalStorageProvider : IStorageProvider
    {
        public void Upload(string fileName, byte[] data)
        {
            Console.WriteLine($"Saving {fileName} to local disk");
        }
    }
}
