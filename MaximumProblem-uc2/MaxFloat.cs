using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumProblem_uc2
{
    class MaxFloat
    {
        static double Max(double FirstNum, double SecondNum, double ThirdNum)
        {
            if (FirstNum.CompareTo(SecondNum) > 0 && FirstNum.CompareTo(ThirdNum) > 0 ||
                FirstNum.CompareTo(SecondNum) >= 0 && FirstNum.CompareTo(ThirdNum) > 0 ||
                FirstNum.CompareTo(SecondNum) > 0 && FirstNum.CompareTo(ThirdNum) >= 0)
            {
                return FirstNum;
            }

            if (SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) > 0 ||
                SecondNum.CompareTo(FirstNum) >= 0 && SecondNum.CompareTo(ThirdNum) > 0 ||
                SecondNum.CompareTo(FirstNum) > 0 && SecondNum.CompareTo(ThirdNum) >= 0)
            {
                return SecondNum;
            }
            if (ThirdNum.CompareTo(FirstNum) > 0 && ThirdNum.CompareTo(SecondNum) > 0 ||
                ThirdNum.CompareTo(FirstNum) >= 0 && ThirdNum.CompareTo(SecondNum) > 0 ||
                ThirdNum.CompareTo(FirstNum) > 0 && ThirdNum.CompareTo(SecondNum) >= 0)
            {
                return ThirdNum;
            }
            return FirstNum;
        }
    }
}
