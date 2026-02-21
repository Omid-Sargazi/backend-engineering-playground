using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.StorageProblem
{
    public abstract class FileResource
    {
        protected IStorageProvider _storageProvider;
        protected FileResource(IStorageProvider storageProvider)
        {
            _storageProvider = storageProvider;
        }

        public abstract void Save(string fileName, byte[] data);
    }
}
