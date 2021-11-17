using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumProblem_uc3
{
    class MaxString
    {
        static String Max(String FirstString, String SecondString, String ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(SecondString) >= 0 && FirstString.CompareTo(ThirdString) > 0 ||
                FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) >= 0)
            {
                return FirstString;
            }

            if (SecondString.CompareTo(FirstString) > 0 && SecondString.CompareTo(ThirdString) > 0 ||
                SecondString.CompareTo(FirstString) >= 0 && SecondString.CompareTo(ThirdString) > 0 ||
                SecondString.CompareTo(FirstString) > 0 && SecondString.CompareTo(ThirdString) >= 0)
            {
                return SecondString;
            }

            if (ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) > 0 ||
                ThirdString.CompareTo(FirstString) >= 0 && ThirdString.CompareTo(SecondString) > 0 ||
                ThirdString.CompareTo(FirstString) > 0 && ThirdString.CompareTo(SecondString) >= 0)
            {
                return ThirdString;
            }
            return FirstString;
        }
    }
}
