using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOutput
    {
        void show();
    }

    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    public interface IOutput2
    {
        void showEven();
        void showOdd();
    }
    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
