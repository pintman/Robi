using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class Element
    {
        List<IElementBeobachter> beobachter = new List<IElementBeobachter>();

        // Die Welt, in der sich das Element befindet
        Welt welt;

        // Ein Bild für das Element
        private Elementbild bild;

        // Die Richtung, in die das Element blickt und sich bewegt
        private Richtung richtung;

        // An dieser Stelle befindet sich das Element
        private Position pPosition;

        String name;

        public Element()
        {
            richtung = new RichtungOsten();
            pPosition = new Position(0, 0);
            name = "";
        }

        public void SetzeName(String neuerName)
        {
            name = neuerName;
        }

        public string HoleName()
        {
            return name;
        }

        public void SetzeWelt(Welt welt)
        {
            this.welt = welt;
        }

        public void SetzeBild(Elementbild neuesBild)
        {
            bild = neuesBild;
        }

        public Boolean ElementHier(Element el)
        {
            return welt.ElementAnStelle(el, pPosition);
        }

        public List<Element> ElementeHier()
        {
            return welt.ElementeAnStelle(pPosition);
        }

        public List<Element> ElementeVorMir()
        {
            return welt.ElementeAnStelle(PositionVorMir());
        }

        public List<Element> ElementeLinksVonMir()
        {
            return welt.ElementeAnStelle(PositionLinksVonMir());
        }

        public List<Element> ElementeRechtsVonMir()
        {
            return welt.ElementeAnStelle(PositionRechtsVonMir());
        }

        public List<Element> SucheElementeVomTyp(Element element)
        {
            return welt.ElementeAnStelle(pPosition).FindAll(el =>
                element.GetType().IsInstanceOfType(el));
        }

        public void EntferneAusWelt()
        {
            welt.EntferneElement(this);
        }

        public Position Position()
        {
            return pPosition;
        }

        public Richtung Richtung()
        {
            return richtung;
        }

        public Position PositionVorMir()
        {
            return pPosition.PositionInRichtung(Richtung());
        }

        public Position PositionLinksVonMir()
        {
            return pPosition.PositionInRichtung(Richtung().RichtungLinks());
        }

        public Position PositionRechtsVonMir()
        {
            return pPosition.PositionInRichtung(Richtung().RichtungRechts());
        }

        public void VerschiebeInRichtung()
        {
            pPosition.VerschiebeInRichtung(Richtung());
            ElementHatPositionGeaendert();
        }

        private bool InnerhalbWelt()
        {
            return welt.EnthaeltPosition(this.pPosition);
        }

        public void VerschiebeEntgegenRichtung()
        {
            DreheUm();
            VerschiebeInRichtung();
            DreheUm();
        }

        public void DreheUm()
        {
            DreheLinks();
            DreheLinks();
        }

        public void DreheRechts()
        {
            richtung = richtung.RichtungRechts();

            // Das Roboterbild aktualisieren.
            bild.DrehenRechts();
            ElementHatPositionGeaendert();
        }

        public void DreheLinks()
        {
            richtung = richtung.RichtungLinks();

            // Das Roboterbild aktualisieren.
            bild.DrehenLinks();
            ElementHatPositionGeaendert();
        }

        public void BewegeNach(Position pZiel)
        {
            pPosition = pZiel;
            ElementHatPositionGeaendert();
        }

        public void BewegeNach(int iX, int iY)
        {
            BewegeNach(new Position(iX, iY));
        }        

        public Image Elementbild()
        {
            return bild.Bild();
        }

        public void FuegeBeobachterHinzu(IElementBeobachter beobachter)
        {
            this.beobachter.Add(beobachter);
        }

        public void ElementHatPositionGeaendert()
        {
            this.beobachter.ForEach(b => b.ElementHatPositionGeaendert());
        }

        public void ElementHatEtwasGesagt(String text)
        {
            this.beobachter.ForEach(b => b.ElementHatEtwasGesagt(this, text));
        }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
