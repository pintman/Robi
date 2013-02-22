using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class RichtungOsten : Richtung
    {
        
        override public Richtung RichtungRechts()
        {
            return new RichtungSueden();
        }

        override public Richtung RichtungLinks()
        {
            return new RichtungNorden();
        }

        override public Richtung RichtungEntgegen()
        {
            return new RichtungWesten();
        }

        override public Position PunktVor(Position punkt)
        {
            return new Position(punkt.X() + 1, punkt.Y());
        }

    }
}
