using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.AdapterPattern
{
    public class MeterCalculator
    {
        public double GetLenghtInMeters(double length)
        {
            return length;
        }
    }

    public interface IInchCalculator
    {
        double GetLengthInInches(double length);
    }

    public class MeterToInchAdapterL : IInchCalculator
    {
        public MeterToInchAdapterL(MeterCalculator meterCalculator)
        {
            _meterCalculator = meterCalculator;
        }
        private readonly MeterCalculator _meterCalculator;
        public double GetLengthInInches(double length)
        {
            return _meterCalculator.GetLengthInMeters(length) * 39.3701;
        }
    }
}
