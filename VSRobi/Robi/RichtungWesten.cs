using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    class RichtungWesten : Richtung
    {
        

        override public Richtung RichtungRechts()
        {
            return new RichtungNorden();
        }

        override public Richtung RichtungLinks()
        {
            return new RichtungSueden();
        }

        override public Richtung RichtungEntgegen()
        {
            return new RichtungOsten();
        }

        override public Position PunktVor(Position punkt)
        {
            return new Position(punkt.X() - 1, punkt.Y());
        }
    }
}
