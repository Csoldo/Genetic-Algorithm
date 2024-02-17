using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    interface Mutator
    {
        public void mutate(Specimen specimen);
    }
}
