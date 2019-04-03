using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_SadraZadehKhameneh.Class
{
    class Sort_10_number
    {
        private  static Int32 Max;
        public  static Int32 FindMaxInTenNumber(Int32[] NewNumber)
        {
            for(int i=0;i<=9;i++)
            {
                if (i == 0)
                    Max = NewNumber[i];
                else if (NewNumber[i] >= Max)
                    Max = NewNumber[i];
            }
            return Max;
        }


    }
}
