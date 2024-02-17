using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class ExponentialFitnessCalculator : FitnessCalculator
    {
        private double exponentialBase;

        public ExponentialFitnessCalculator(double exponentialBase)
        {
            this.exponentialBase = exponentialBase;
        }

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

            specimen.setFitness(Math.Pow(this.exponentialBase, fitness - (specimen.getGene().Length + 1)));
            //a^b/a^c
        }
    }
}
