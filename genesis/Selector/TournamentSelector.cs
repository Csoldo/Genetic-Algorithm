using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class TournamentSelector : Selector
    {
        private Random random;

        public TournamentSelector()
        {
            this.random = new Random();
        }

        public Specimen selectParent(Generation g)
        {
            List<Specimen> specimens = g.getSpecimens();
            int firstIndex = this.random.Next(0, g.getSpecimens().Count);
            int secondIndex = this.random.Next(0, g.getSpecimens().Count);
            if(g.getSpecimens()[firstIndex].getFitness() > g.getSpecimens()[secondIndex].getFitness())
            {
                return g.getSpecimens()[firstIndex];
            }
            return g.getSpecimens()[secondIndex];
        }

        public Specimen selectParent(Generation g, Specimen firstParent)
        {
            Specimen selected = selectParent(g);
            if( firstParent == selected)
            {
                return g.getSpecimens()[0];
            }
            return selected;
        }
    }
}
