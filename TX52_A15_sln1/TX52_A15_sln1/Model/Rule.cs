using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TX52_A15_sln1.Model
{
   public class Rule
    {

        private int id;
        private string label;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
    }
}
