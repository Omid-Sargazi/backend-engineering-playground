using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern.ReportingEngine
{
    public interface IReportExporter
    {
        void Export(string reportData);
    }
}
