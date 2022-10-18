using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class PolynomialFitnessCalculator : FitnessCalculator
    {
        private double power;
        public PolynomialFitnessCalculator(double power)
        {
            this.power = power;
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

            specimen.setFitness(Math.Pow(fitness/specimen.getGene().Length, this.power));

            // (a)^b/(c)^b
        }
    }
}
