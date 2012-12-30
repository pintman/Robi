using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Robi
{
    public class Position
    {
        Point position;

        public Position(int x, int y)
        {
            position = new Point(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj is Position)
            {
                return position.Equals((obj as Position).position);
            }
            else
            {
                return false;
            }
        }

        public int X()
        {
            return position.X;
        }

        public int Y()
        {
            return position.Y;
        }

        public void VerschiebeInRichtung(Richtung richtung)
        {
            Position positionNeu = PositionInRichtung(richtung);
            position.X = positionNeu.X();
            position.Y = positionNeu.Y();
        }

        public Position PositionInRichtung(Richtung richtung)
        {
            return richtung.PunktVor(this);
        }

        public void Verschiebe(int deltaX, int deltaY)
        {
            position.Offset(deltaX, deltaY);
        }

        public override int GetHashCode()
        {
            return position.GetHashCode();
        }
    }
}
