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

        /// <summary>
        /// Erstellt einen Roboter mit dem angegebenen Namen.
        /// </summary>
        public Roboter(string name)
            : base()
        {
            // Den Roboter mit dem Bild erstellen
            // Bei der Erstellung muss für den Roboter ein Bild hinterlegt werden. Dies ist eine 
            // Bild-Datei im Projekt, die über Robi.Properties.Resources.robot zugegriffen werden kann.
            // Diese wurde zuvor in den Projekeigentschaften angemeldet

            SetzeName(name);
            inventar = new List<Gegenstand>();
            SetzeBild(new Elementbild(Robi.Properties.Resources.robot));
        }

        /// <summary>
        /// Erstellt einen Roboter ohne Namen.
        /// </summary>
        public Roboter()
            : this("Namenlos")
        {
        }

        /// <summary>
        /// Nimmt die angegebenen Gegenstände auf.
        /// </summary>
        public void NimmAlleAuf(List<Gegenstand> gegenstaende)
        {
            gegenstaende.ForEach(g => 
                {
                    inventar.Add(g);
                    g.EntferneAusWelt();
                });
        }

        /// <summary>
        /// Der Roboter geht einen Schritt vor.
        /// </summary>
        public void GeheVor()
        {
            VerschiebeInRichtung();
        }

        /// <summary>
        /// Der Roboter sagt etwas den angegebenen Text.
        /// </summary>
        public void Sage(String text)
        {
            ElementHatEtwasGesagt(text);
        }

        /// <summary>
        /// Das Inventar des Roboters wird als String zurückgegeben.
        /// </summary>
        public String MeinInventar()
        {
            String sInventar = "";
            inventar.ForEach(inv => sInventar += inv.ToString() + " ");
            return sInventar;
        }

        /// <summary>
        /// Prüft, ob sich ein Werkzeug vor dem Roboter befindet.
        /// </summary>
        public Boolean WerkzeugVorMir()
        {
            return ElementeVorMir().Find(el => el is Werkzeug) != null;
        }

        /// <summary>
        /// Prüft, ob sich ein Fels vor dem Roboter befindet.
        /// </summary>
        public Boolean FelsVorMir()
        {
            return ElementeVorMir().Find(el => el is Fels) != null;
        }

        /// <summary>
        /// Prüft, ob sich ein Fels links vom Roboter befindet.
        /// </summary>
        public Boolean FelsLinks()
        {
            return ElementeLinksVonMir().Find(el => el is Fels) != null;
        }

        /// <summary>
        /// Prüft, ob sich ein Werkzeug rechts vom Roboter befindet.
        /// </summary>
        public Boolean FelsRechts()
        {
            return ElementeRechtsVonMir().Find(el => el is Fels) != null;
        }

        /// <summary>
        /// Diese Methode wird in jeder Runde ausgeführt und beschreibt, was der Roboter tut.
        /// </summary>
        override public void Aktion()
        {
        }

        /// <summary>
        /// Der Roboter sucht an der aktuellen Position nach Gegenständen.
        /// </summary>
        public List<Gegenstand> SucheGegenstaende()
        {
            List<Gegenstand> gegenstaende = new List<Gegenstand>();
            SucheElementeVomTyp(new Gegenstand()).ForEach(g => gegenstaende.Add((Gegenstand) g));
            return gegenstaende;
        }

        /// <summary>
        /// Prüft, ob hier ein Werkzeug ist.
        /// </summary>
        public Boolean WerkzeugHier()
        {
            return ElementHier(new Werkzeug());            
        }
    }
}
