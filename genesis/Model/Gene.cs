using System;
using System.Collections.Generic;
using System.Text;

namespace genesis.Model
{
    interface Gene
    {
        string toString();

        int getLength();

        int compareTo(Gene gene);
    }
}
