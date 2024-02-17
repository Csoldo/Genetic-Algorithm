using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    interface Renderer
    {
        public void renderGeneration(Generation generation);
        public void renderSpecimen(Specimen specimen);
    }
}
