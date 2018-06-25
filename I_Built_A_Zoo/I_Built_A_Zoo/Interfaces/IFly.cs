using System;
using System.Collections.Generic;
using System.Text;

namespace I_Built_A_Zoo.Interfaces
{
    public interface IFly
    {
        string WingSpan { get; set; }

        string CoveredEnclosure();

    }
}
