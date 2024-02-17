using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class FullRandomMutator : Mutator
    {
        private int rate;
        private Random random;
        public FullRandomMutator(int rate)
        {
            this.rate = rate;
            this.random = new Random();
        }
        public void mutate(Specimen specimen)
        {
            char[] gene = specimen.getGene().ToCharArray();

            for (int i = 0; i < gene.Length; i++)
            {
                if (random.Next(0, 1001) < rate)
                {
                    gene[i] = God.genePool[this.random.Next(0, God.genePool.Length)];
                }
            }

            specimen.setGene(new string(gene));
        }
    }
}
