using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class Specimen
    {
        private string gene;

        private double fitness;

        public Specimen(string gene)
        {
            this.gene = gene;
        }

        public Specimen(int geneLength)
        {
            this.gene = "";
            Random rand = new Random();

            for (int i = 0; i < geneLength; i++)
            {
                gene += God.genePool[rand.Next(0, God.genePool.Length)];
            }
        }

        public void setGene(string gene)
        {
            this.gene = gene;
        }

        public string getGene()
        {
            return this.gene;
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }
    }
}
