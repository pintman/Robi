using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    abstract public class Richtung
    {
        abstract public Position PunktVor(Position punkt);
        abstract public Richtung RichtungRechts();
        abstract public Richtung RichtungLinks();
        abstract public Richtung RichtungEntgegen();
    }
}
