using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Robi
{
    public partial class RobiDialog : Form, IElementBeobachter
    {
        Roboter robi;
        Welt welt;

        public RobiDialog()
        {
            // Der Dialog wird mit der Zeichenfläche und seinen Komponenten initialisiert.
            InitializeComponent();

            WeltErzeugen();
        }

        private void WeltErzeugen()
        {
            // Die Welt wird erstellt
            welt = Welt.ErzeugeBeispielwelt();

            robi = new Sammler();
            robi.BewegeNach(1, 1);
            robi.FuegeBeobachterHinzu(this);
            welt.FuegeElementHinzu(robi);
        }

        private void pbZeichenflaeche_Paint(object sender, PaintEventArgs e)
        {
            welt.ZeichneAuf(e.Graphics);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            welt.FuehreEinenZylkusAus();
        }

        private void AnsichtAktualisieren()
        {
            pbZeichenflaeche.Invalidate();
            Ausgabe("X:" + robi.Position().X() + " Y:" + robi.Position().Y() + " ");
            Ausgabe("Richtung:" + robi.Richtung());
        }

        private void Ausgabe(String text)
        {
            tbAusgabe.Text = text + System.Environment.NewLine + tbAusgabe.Text;
        }

        private void btnDreheRechts_Click(object sender, EventArgs e)
        {
            robi.DreheRechts();
        }

        private void btnDreheLinks_Click(object sender, EventArgs e)
        {
            robi.DreheLinks();
        }

        public void ElementHatPositionGeaendert()
        {
            AnsichtAktualisieren();
        }

        public void ElementHatEtwasGesagt(Element element, String text)
        {
            Ausgabe(element.HoleName() + ": " + text);
        }

        private void pbZeichenflaeche_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Elemente: ";
            statusZeile.Text = "";
            Position pos = welt.TransformierePixelKoordinaten(pbZeichenflaeche.CreateGraphics(), e.Location);
            welt.ElementeAnStelle(pos).ForEach(el => toolStripStatusLabel1.Text += el.ToString()+ " ");
        }
    }
}
