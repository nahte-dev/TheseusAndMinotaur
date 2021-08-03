using System;
using System.Collections.Generic;
using System.Text;

namespace TheseusAndMinotaur
{
    interface IMoveable
    {
        void GoUp();
        void GoDown();
        void GoLeft();
        void GoRight();
        int Row { get; }
        int Column { get; }
    }
}
