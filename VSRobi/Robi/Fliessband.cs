using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class Fliessband : Akteur
    {
        public Fliessband()
            : base()
        {
            SetzeName("Fließband");
            SetzeBild(new Elementbild(Robi.Properties.Resources.fliessband));
        }

        public override void Aktion()
        {
            SucheElementeVomTyp(new Roboter()).
                ForEach(rob => 
                    rob.BewegeNach(PositionVorMir()));
        }
    }
}
