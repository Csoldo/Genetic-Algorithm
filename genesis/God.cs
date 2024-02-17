using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class God
    {
        public static string genePool = "abcdefghijklmnopqrstuvwxyz ";
        private List<GenerationStatistics> generations;
        private int generationSize;
        private int geneSize;

        private Specimen original;

        private Selector selector;

        private Mutator mutator;

        private FitnessCalculator fitnessCalculator;

        private Breeder breeder;

        private Renderer renderer;

        private Generation currentGeneration;

        public God(int generationSize, string originalGene, Selector selector, Mutator mutator, FitnessCalculator fitnessCalculator, Breeder breeder, Renderer renderer)
        {
            this.generationSize = generationSize;
            this.geneSize = originalGene.Length;
            this.original = new Specimen(originalGene.ToLower());
            this.selector = selector;
            this.mutator = mutator;
            this.fitnessCalculator = fitnessCalculator;
            this.breeder = breeder;
            this.renderer = renderer;
            this.generations = new List<GenerationStatistics>();
        }


        private void init()
        {
            Generation g = new Generation(this.generations.Count);
            
            List<Specimen> specimens = generateSpecimens();
            for (int i = 0; i < specimens.Count; i++)
            {
                this.fitnessCalculator.calculate(specimens[i], this.original);
            }
            g.setSpecimens(specimens);
            this.generations.Add(g.createStatistics());
            this.renderer.renderGeneration(g);
            if(this.selector is SortedSelector)
            {
                g.sortSpecimens();
            }

            this.currentGeneration = g;
        }

        private void next()
        {
            PoolSelector.sumIndex = 0;
            PoolSelector.randomSum = 0;
            Generation g = new Generation(this.generations.Count);
            for (int i = 0; i < this.generationSize; i++)
            {
                Specimen firstParent = this.selectFirstParent();
                Specimen secondParent = this.selectSecondParent(firstParent);
                Specimen child = this.breeder.breed(firstParent, secondParent);
                this.mutator.mutate(child);
                this.fitnessCalculator.calculate(child, this.original);
                g.addSpecimen(child);
            }

            this.generations.Add(g.createStatistics());
            if (this.selector is SortedSelector)
            {
                g.sortSpecimens();
            }

            this.renderer.renderGeneration(g);
            //Console.WriteLine(PoolSelector.sumIndex / (this.generationSize * 2));
            //Console.WriteLine(PoolSelector.randomSum / (this.generationSize * 2));
           
            this.currentGeneration = g;
        }

        public void run()
        {
            init();
            while (!currentGenerationHasOriginal())
            {
                next();
                //Console.ReadKey();
            }


        }

        private Specimen selectFirstParent()
        {
            return this.selector.selectParent(currentGeneration);
        }

        private Specimen selectSecondParent(Specimen firstParent)
        {
            return this.selector.selectParent(currentGeneration, firstParent);
        }

        private List<Specimen> generateSpecimens()
        {
            List<Specimen> specimens = new List<Specimen>();
            for (int i = 0; i < this.generationSize; i++)
            {
                specimens.Add(new Specimen(this.geneSize));
            }
            return specimens;
        }

        private bool currentGenerationHasOriginal()
        {
            List<Specimen> specimens = currentGeneration.getSpecimens();
            for (int i = 0; i < specimens.Count; i++)
            {
                if (specimens[i].getGene() == this.original.getGene())
                {
                    //this.renderer.renderSpecimen(specimens[i]);
                    return true;
                }
            }

            return false;
        }

        public int getNumberOfSpecimens()
        {
            return generations.Count * generationSize;
        }

        public void reset()
        {           
            this.generations = new List<GenerationStatistics>();
        }
    }
}
