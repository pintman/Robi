using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class Werkzeug : Gegenstand
    {
        public Werkzeug()
            : base()
        {
            SetzeName("Werkzeug");
            Elementbild bild = new Elementbild(Robi.Properties.Resources.tool);
            SetzeBild(bild);
        }
    }
}
