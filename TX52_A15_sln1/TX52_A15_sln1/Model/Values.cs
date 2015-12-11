using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TX52_A15_sln1.Model
{
    public class Values
    {
        Double max;
        Double min;
        Double val;

        public Values()
        {
            this.Min = 0.0;
            this.Max = 0.0;
            this.Val = 0.0;
        }

        public Values(Values v)
        {
            this.Val = v.Val;
            this.Max = v.Max;
            this.Min = v.Min;
        }

        public Double Max
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }

        public Double Min
        {
            get
            {
                return min;
            }

            set
            {
                min = value;
            }
        }

        public Double Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }
    }
}
