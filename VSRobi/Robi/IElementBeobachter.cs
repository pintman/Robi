using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Robi
{
    public interface IElementBeobachter
    {
        void ElementHatPositionGeaendert();
        void ElementHatEtwasGesagt(Element element, String text);
    }
}
