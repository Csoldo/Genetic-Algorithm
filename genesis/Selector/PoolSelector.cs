using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class PoolSelector : Selector
    {
        private Random random;
        public static int sumIndex = 0;
        public static double randomSum = 0;

        public PoolSelector()
        {
            this.random = new Random();
        }

        public Specimen selectParent(Generation g)
        {
            double sum = getSumOfSpecimenFitness(g);
            //Console.WriteLine(sum);
            
            List<Specimen> specimens = g.getSpecimens();

            double random = this.random.NextDouble() * 100;
            //Console.WriteLine(random);
            randomSum += random;

            double currentSum = this.mapFitnessToAHundred(specimens[0], sum, specimens[0].getFitness());
            int i = 0;

            while (currentSum < random)
            {
                i++;
                currentSum += this.mapFitnessToAHundred(specimens[i], sum, specimens[0].getFitness());
            }
            sumIndex += i;
            //Console.WriteLine("Selected index: " + i);
            
            return specimens[i];
        }

        public Specimen selectParent(Generation g, Specimen firstParent)
        {
            Specimen selected = selectParent(g);
            if (firstParent == selected)
            {
                return g.getSpecimens()[0];
            }
            return selected;
        }

        private double getSumOfSpecimenFitness(Generation g)
        {
            List<Specimen> specimens = g.getSpecimens();
            int length = specimens.Count;
            double sum = 0;
            for(int i = 0; i < length; i++)
            {
                sum += specimens[i].getFitness();
            }
            return sum;
        }

        private double mapFitnessToAHundred(Specimen specimen, double sumOfSpecimenFitness, double maxFitness)
        {
            double probabilityOfChoosingOne = 100.0 / (double)sumOfSpecimenFitness;
            //Console.WriteLine(specimen.getFitness() + " // " + (probabilityOfChoosingOne * (double) specimen.getFitness()));
            return probabilityOfChoosingOne * (double) specimen.getFitness();
        }
    }
}

