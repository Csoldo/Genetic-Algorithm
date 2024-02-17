using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class SpecimenComparer : IComparer<Specimen>
    {
        public int Compare(Specimen specimen1, Specimen specimen2)
        {
            return specimen2.getFitness().CompareTo(specimen1.getFitness());
        }
    }
}
