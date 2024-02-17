using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    interface Selector
    {
        public Specimen selectParent(Generation g);
        public Specimen selectParent(Generation g, Specimen firstParent);
    }
}
