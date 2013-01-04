using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class Welt
    {
        List<Element> elemente;
        int iBreite;
        int iHoehe;

        /// <summary>
        /// Erstelle eine Welt mit breite * hoehe Kacheln. Der Ursprung (0|0) ist oben links.
        /// </summary>
        public Welt(int _iBreite, int _iHoehe)
        {
            this.iBreite = _iBreite;
            this.iHoehe = _iHoehe;
            elemente = new List<Element>();

            for (int i = 0; i < iBreite; i++)
            {
                for (int j = 0; j < iHoehe; j++)
                {
                    Boden boden = new Boden();
                    boden.BewegeNach(i, j);
                    FuegeElementHinzu(boden);
                }
            }
        }

        public void FuegeElementHinzu(Element element)
        {
            elemente.Add(element);
            element.SetzeWelt(this);
        }

        public void ZeichneAuf(Graphics g)
        {
            g.Clear(Color.White);

            elemente.ForEach(el =>
                g.DrawImage(el.Elementbild(), TransformiereKoordinaten(g, el.Position())));
        }

        /// <summary>
        /// Transformiert die logischen Koordinaten auf Bildschirmpixel.
        /// </summary>
        private Point TransformiereKoordinaten(Graphics g, Position punkt)
        {
            int iSchrittweiteX = Convert.ToInt32(g.VisibleClipBounds.Width / this.iBreite);
            int iSchrittweiteY = Convert.ToInt32(g.VisibleClipBounds.Height / this.iHoehe);

            return new Point(punkt.X() * iSchrittweiteX, punkt.Y() * iSchrittweiteY);
        }

        public Position TransformierePixelKoordinaten(Graphics g, Point pixelKoordinaten)
        {
            int iSchrittweiteX = Convert.ToInt32(g.VisibleClipBounds.Width / this.iBreite);
            int iSchrittweiteY = Convert.ToInt32(g.VisibleClipBounds.Height / this.iHoehe);

            return new Position(pixelKoordinaten.X / iSchrittweiteX, pixelKoordinaten.Y / iSchrittweiteY);
        }

        public bool EnthaeltPosition(Position point)
        {
            return point.X() >= 0
                && point.X() <= iBreite - 1
                && point.Y() >= 0
                && point.Y() <= iHoehe - 1;
        }

        public List<Element> ElementeAnStelle(Position pPosition)
        {
            return elemente.FindAll(el =>
                el.Position().Equals(pPosition));
        }

        public void EntferneElement(Element element)
        {
            elemente.Remove(element);
        }

        public static Welt ErzeugeBeispielwelt()
        {
            Welt welt = new Welt(10, 10);

            // Platziere zwei Werkzeuge
            Werkzeug tool = new Werkzeug();
            tool.SetzeName("Zange 1");
            tool.BewegeNach(3, 3);
            welt.FuegeElementHinzu(tool);

            tool = new Werkzeug();
            tool.SetzeName("Zange 2");
            tool.BewegeNach(3, 1);
            welt.FuegeElementHinzu(tool);

            // Platziere Fliessbaender
            Fliessband fliessband;
            for (int i = 3; i <= 6; i++)
            {
                fliessband = new Fliessband();
                fliessband.BewegeNach(i, 6);
                welt.FuegeElementHinzu(fliessband);
            }
            for (int i = 3; i <= 6; i++)
            {
                fliessband = new Fliessband();
                fliessband.DreheLinks();
                fliessband.BewegeNach(7, i);
                welt.FuegeElementHinzu(fliessband);
            }
            // Zahnrad platzieren
            DrehendesZahnrad zahnrad = new DrehendesZahnrad();
            zahnrad.BewegeNach(8, 8);
            welt.FuegeElementHinzu(zahnrad);            

            // Umrande mit Felsen
            Fels fels;
            for (int i = 0; i < welt.iBreite; i++)
            {
                // oben
                fels = new Fels();
                fels.BewegeNach(i, 0);
                welt.FuegeElementHinzu(fels);
                // unten
                fels = new Fels();
                fels.BewegeNach(i, welt.iHoehe - 1);
                welt.FuegeElementHinzu(fels);
            }
            for (int i = 1; i < welt.iHoehe; i++)
            {
                // links
                fels = new Fels();
                fels.BewegeNach(0, i);
                welt.FuegeElementHinzu(fels);
                // unten
                fels = new Fels();
                fels.BewegeNach(welt.iBreite - 1, i);
                welt.FuegeElementHinzu(fels);
            }

            return welt;
        }

        public void FuehreEinenZylkusAus()
        {
            // Roboter tun etwas
            elemente.FindAll(el => el is Roboter).
                ForEach(rob => (rob as Roboter).Aktion());

            // Die Fließbänder, die von Robotern besetzt sind, treten in Aktion
            elemente.FindAll(el => el is Fliessband && el.ElementHier(new Roboter())).
                ForEach(fl => (fl as Fliessband).Aktion());

            // Zahnräder drehen sich
            elemente.FindAll(el => el is DrehendesZahnrad && el.ElementHier(new Roboter())).
                ForEach(zahnr => (zahnr as DrehendesZahnrad).Aktion());
        }
    }
}
