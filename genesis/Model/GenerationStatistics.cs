using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class GenerationStatistics
    {
        private Specimen bestSpecimen;
        private double avarageFitness;
        private double variance;


        public GenerationStatistics(Specimen bestSpecimen, double avarageFitness, double variance)
        {
            this.bestSpecimen = bestSpecimen;
            this.avarageFitness = avarageFitness;
            this.variance = variance;
        }

        public Specimen getBestSpecimen()
        {
            return this.bestSpecimen;
        }

        public double getAvarageFitness()
        {
            return this.avarageFitness;
        }

        public double getVariance()
        {
            return this.variance;
        }
    }
}
