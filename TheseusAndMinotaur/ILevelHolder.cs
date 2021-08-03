using System;
using System.Collections.Generic;
using System.Text;

namespace TheseusAndMinotaur
{
    interface ILevelHolder
    {
        void AddLevel(string name, int width, int height, string data);
    }
}
