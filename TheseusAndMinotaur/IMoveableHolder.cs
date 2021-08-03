using System;
using System.Collections.Generic;
using System.Text;

namespace TheseusAndMinotaur
{
    interface IMoveableHolder
    {

        int MinotaurRow { get; }
        int MinotaurColumn { get; }
        int MoveCount { get; }
        int TheseusRow { get; }
        int TheseusColumn { get; }
        void MoveTheseus(Moves direction);
        bool HasMinotaurWon();
        bool HasTheseusWon();

    }
}
