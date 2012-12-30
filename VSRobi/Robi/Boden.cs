using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class Boden : Element
    {
        public Boden()
            : base()
        {
            SetzeName("Boden");
            Elementbild bild = new Elementbild(Robi.Properties.Resources.texturBoden);
            SetzeBild(bild);
        }
    }
}
