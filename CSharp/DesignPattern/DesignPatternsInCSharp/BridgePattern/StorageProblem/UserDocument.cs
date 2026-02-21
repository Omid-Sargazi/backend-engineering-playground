using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.StorageProblem
{
    public class UserDocument : FileResource
    {
        public UserDocument(IStorageProvider storageProvider) : base(storageProvider)
        {
        }
        public override void Save(string fileName, byte[] data)
        {
            _storageProvider.Upload(fileName, data);
        }
    }

    public class InvoiceFile : FileResource
    {
        public InvoiceFile(IStorageProvider storage)
        : base(storage) { }

        public override void Save(string fileName, byte[] data)
        {
            throw new NotImplementedException();
        }
    }

}
