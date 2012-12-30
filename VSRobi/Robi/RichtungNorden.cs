using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class RichtungNorden : Richtung
    {
        
        override public Richtung RichtungRechts()
        {
            return new RichtungOsten();
        }

        override public Richtung RichtungLinks()
        {
            return new RichtungWesten();
        }

        override public Richtung RichtungEntgegen()
        {
            return new RichtungSueden();
        }

        override public Position PunktVor(Position punkt)
        {
            return new Position(punkt.X(), punkt.Y() - 1);
        }

    }
}
