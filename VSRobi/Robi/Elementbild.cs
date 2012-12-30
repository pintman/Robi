using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class Elementbild
    {
        // Das Bild des Elementes
        private Image bild;

        public Elementbild(Image _bild)
        {
            bild = _bild;
        }

        public void DrehenRechts()
        {
            bild.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        public void DrehenLinks()
        {
            bild.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        public Image Bild()
        {
            return bild;
        }
    }
}
