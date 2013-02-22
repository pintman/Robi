using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public class Sammler : Roboter
    {
        public Sammler()
            : base("Sammler")
        {
        }

        public override void Aktion()
        {
            if (FelsVorMir())
            {
                DreheLinks();
            }
            else
            {
                GeheVor();
            }

            if (WerkzeugVorMir())
            {
                Sage("Ein Werkzeug ist vor mir");
            }
            if (WerkzeugHier())
            {
                NimmAlleAuf(SucheGegenstaende());
                Sage("Werkzeug genommen. " + MeinInventar());
            }
        }
    }
}
