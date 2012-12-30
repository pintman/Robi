using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Hier ist die Klasse Point drin
using System.Drawing;

namespace Robi
{
    public class Roboter : Akteur
    {
        List<Gegenstand> inventar;

        public Roboter(string name)
            : base()
        {
            // Den Roboter mit dem Bild erstellen
            // Bei der Erstellung muss für den Roboter ein Bild hinterlegt werden. Dies ist eine 
            // JPG-Datei im Projekt, die über Robi.Properties.Resources.robot zugegriffen werden kann.
            // Diese wurde zuvor in den Projekeigentschaften angemeldet

            SetzeName(name);
            inventar = new List<Gegenstand>();
            SetzeBild(new Elementbild(Robi.Properties.Resources.robot));
        }

        public Roboter()
            : this("Namenlos")
        {
        }

        public void NimmAlleAuf(List<Gegenstand> gegenstaende)
        {
            gegenstaende.ForEach(g => 
                {
                    inventar.Add(g);
                    g.EntferneAusWelt();
                });
        }

        public void GeheVor()
        {
            VerschiebeInRichtung();
        }

        public void Sage(String text)
        {
            ElementHatEtwasGesagt(text);
        }

        public Boolean WerkzeugVorMir()
        {
            return ElementeVorMir().Find(el => el is Werkzeug) != null;
        }

        public Boolean FelsVorMir()
        {
            return ElementeVorMir().Find(el => el is Fels) != null;
        }

        override public void Aktion()
        {
            if (!FelsVorMir())
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
                Sage("Werkzeug genommen");                
                inventar.ForEach(inv => Sage(inv.ToString()));
            }
        }

        public List<Gegenstand> SucheGegenstaende()
        {
            List<Gegenstand> gegenstaende = new List<Gegenstand>();
            SucheElementeVomTyp(new Gegenstand()).ForEach(g => gegenstaende.Add((Gegenstand) g));
            return gegenstaende;
        }

        public Boolean WerkzeugHier()
        {
            return ElementHier(new Werkzeug());            
        }
    }
}
