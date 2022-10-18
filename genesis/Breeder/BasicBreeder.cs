using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class BasicBreeder : Breeder
    {
        public Specimen breed(Specimen parentA, Specimen parentB)
        {
            string gene = "";
            Random random = new Random();

            for (int i = 0; i < parentA.getGene().Length; i++)
            {
                if (random.Next(0, 2) == 0)
                {
                    gene += parentA.getGene()[i];
                }
                else
                {
                    gene += parentB.getGene()[i];
                }
            }

            return new Specimen(gene);
        }
    }
}
