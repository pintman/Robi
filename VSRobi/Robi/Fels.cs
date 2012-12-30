using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class Fels : Gegenstand
    {
        public Fels()
            : base()
        {
            SetzeName("Fels");
            SetzeBild(new Elementbild(Robi.Properties.Resources.rock));
        }
    }
}
