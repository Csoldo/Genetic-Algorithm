using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class Generation
    {
        private List<Specimen> specimens;

        private int generationNumber;

        public Generation(int generationNumber)
        {
            this.generationNumber = generationNumber;
            this.specimens = new List<Specimen>();
        }

        public void setSpecimens(List<Specimen> specimens)
        {
            this.specimens = specimens;
        }

        public void addSpecimen(Specimen specimen)
        {
            this.specimens.Add(specimen);
        }

        public void sortSpecimens()
        {
            specimens.Sort(new SpecimenComparer());
        }

        public List<Specimen> getSpecimens()
        {
            return this.specimens;
        }

        public int getGenerationNumber()
        {
            return this.generationNumber;
        }

        public double getAvarageFitness()
        {
            double sum = 0;
            int length = specimens.Count;
            for (int i = 0; i < length; i++)
            {
                sum += specimens[i].getFitness();
            }

            return (double)sum / (double)length;
        }

        public GenerationStatistics createStatistics()
        {
            return new GenerationStatistics(specimens[0], getAvarageFitness(), getVariance());
        }

        public double getVariance()
        {
            return specimens[0].getFitness() - specimens[specimens.Count - 1].getFitness();
        }

    }
}
