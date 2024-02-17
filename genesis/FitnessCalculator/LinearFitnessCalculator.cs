using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class LinearFitnessCalculator : FitnessCalculator
    {
        public void calculate(Specimen specimen, Specimen original)
        {
            double fitness = 1;
            for (int i = 0; i < specimen.getGene().Length; i++)
            {
                if (specimen.getGene()[i] == original.getGene()[i])
                {
                    fitness++;
                }
            }

            specimen.setFitness(fitness);
        }
    }
}
