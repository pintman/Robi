using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class DrehendesZahnrad : Akteur
    {
        public DrehendesZahnrad()
            : base()
        {
            SetzeName("Zahnrad");
            SetzeBild(new Elementbild(Properties.Resources.drehendeszahnrad));
        }

        public override void Aktion()
        {
            SucheElementeVomTyp(new Roboter()).
                ForEach(rob => rob.DreheRechts());
        }
    }
}
