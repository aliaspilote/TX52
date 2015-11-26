using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Modelisator.Model;


namespace Modelisator.MyGraphSharp
{
    public class PocVertex
    {
        public string ID { get; private set; }
        public bool IsMale { get; private set; }
        public GrandeurPhysique GP { get; set; }

        public PocVertex(string id, bool isMale)
        {
            ID = id;
            IsMale = isMale;
        }


        public PocVertex(GrandeurPhysique GP)
        {
            this.GP = GP;
            ID = GP.Nom;
            IsMale = true;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", ID, IsMale);
        }
    }
}
