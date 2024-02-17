using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    interface FitnessCalculator
    {
        public void calculate(Specimen specimen, Specimen original);
    }
}
