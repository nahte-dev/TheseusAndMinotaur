using System;
using System.Collections.Generic;
using System.Text;

namespace TheseusAndMinotaur
{
    interface ILevel
    {
        string Name { get; }
        int Width { get; }
        int Height { get; }
        string Data { get; }
    }
}
