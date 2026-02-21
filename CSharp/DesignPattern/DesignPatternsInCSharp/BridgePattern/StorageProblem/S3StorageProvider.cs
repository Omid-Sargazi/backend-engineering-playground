using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.StorageProblem
{
    public class S3StorageProvider : IStorageProvider
    {
        public void Upload(string fileName, byte[] data)
        {
            Console.WriteLine($"Uploading {fileName} to AWS S3");
        }
    }
}
