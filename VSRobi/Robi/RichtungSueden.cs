using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    class RichtungSueden : Richtung
    {
        

        override public Richtung RichtungRechts()
        {
            return new RichtungWesten();
        }

        override public Richtung RichtungLinks()
        {
            return new RichtungOsten();
        }

        override public Richtung RichtungEntgegen()
        {
            return new RichtungNorden();
        }

        override public Position PunktVor(Position punkt)
        {
            return new Position(punkt.X(), punkt.Y() + 1);
        }

    }
}
