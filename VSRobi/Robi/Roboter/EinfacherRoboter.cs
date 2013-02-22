using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    /// <summary>
    /// Ein einfacher Roboter läuft immmer geradeaus und biegt an einem Hindernis links ab.
    /// Er sammelt nichts ein.
    /// </summary>
    public class EinfacherRoboter : Roboter
    {
        public EinfacherRoboter()
            : base("Einfacher Robi")
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
        }
    }
}
