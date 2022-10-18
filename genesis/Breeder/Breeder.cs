using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    interface Breeder
    {
        public Specimen breed(Specimen parentA, Specimen parentB);
    }
}
