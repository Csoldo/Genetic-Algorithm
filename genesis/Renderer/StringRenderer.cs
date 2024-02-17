using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class StringRenderer : Renderer
    {
        public void renderGeneration(Generation generation)
        {
            List<Specimen> specimens = generation.getSpecimens();
            for(int i = 0; i < specimens.Count; i++)
            {
                //renderSpecimen(specimens[i]);
            }
            
            /*Console.WriteLine("\nGENERATION: " + generation.getGenerationNumber());
            Console.WriteLine("Avarage generation fitness: " + generation.getAvarageFitness());
            Console.WriteLine("Difference between best and worst specimen: " + (specimens[0].getFitness() - specimens[specimens.Count - 1].getFitness()));
            Console.Write("Best specimen: ");
            renderSpecimen(specimens[0]);
            Console.WriteLine("\n----------------------\n");
            */
        }

        public void renderSpecimen(Specimen specimen)
        {
            Console.WriteLine(specimen.getGene() + "    fitness: " + specimen.getFitness());
        }
    }
}
