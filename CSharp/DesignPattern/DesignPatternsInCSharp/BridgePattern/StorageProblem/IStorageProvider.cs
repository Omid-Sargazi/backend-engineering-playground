using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.StorageProblem
{
    public interface IStorageProvider
    {
        void Upload(string fileName, byte[] data)
    }
}
