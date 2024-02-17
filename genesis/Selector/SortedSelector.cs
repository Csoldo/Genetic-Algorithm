using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class SortedSelector : Selector
    {
        private int probability;
        private Random random;

        public SortedSelector(int probability)
        {
            this.probability = probability;
            this.random = new Random();
        }

        public Specimen selectParent(Generation g)
        {
            List<Specimen> specimens = g.getSpecimens();
            for (int i = 0; i < specimens.Count; i++)
            {
                int rnd = random.Next(0, 1000);
                if(rnd < probability)
                {
                    return specimens[i];
                }
            }
            return specimens[0];
        }

        public Specimen selectParent(Generation g, Specimen firstParent)
        {
            List<Specimen> specimens = g.getSpecimens();
            for (int i = 0; i < specimens.Count; i++)
            {
                if(specimens[i] == firstParent)
                {
                    continue;
                }

                int rnd = random.Next(0, 1000);
                if (rnd < probability)
                {
                    return specimens[i];
                }
            }
            if(specimens[0] == firstParent)
            {
                return specimens[1];
            }
            return specimens[0];
        }
    }
}
