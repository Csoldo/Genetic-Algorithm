using System;
using System.Threading;

namespace genesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trying sonarscanner
            //asd
            DateTime timer = DateTime.Now;
            Mutator mutator = new FullRandomMutator(1);//1-1000

            Selector selector = new SortedSelector(15);//1-1000
            Selector poolSelector = new PoolSelector();//1-1000
            Selector tournamentSelector = new TournamentSelector();

            Renderer renderer = new StringRenderer();
            Breeder breeder = new BasicBreeder();

            FitnessCalculator fitnessCalculator = new LinearFitnessCalculator();
            FitnessCalculator polynomialFitnessCalculator = new PolynomialFitnessCalculator(3);
            FitnessCalculator exponentialFitnessCalculator = new ExponentialFitnessCalculator(2);
            

            string specimenZero = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            string spec = "kitalalando string barmilyen hosszu lehet, de a fitness fuggvenyeket kell megirni hozza, es a mutatorokat, selectort, breederet, rendereret, es a godot, meg a simulatorokat, es a gene interface-t, es a gene implementaciokat";

            string test = "szia bazdmeg kutyaidat setaltatod";
            string asd = "random string ";

            God god = new God(2500, specimenZero, selector, mutator, fitnessCalculator, breeder, renderer);
            God god2 = new God(1000, spec, poolSelector, mutator, exponentialFitnessCalculator, breeder, renderer);
            God god3 = new God(2500, specimenZero, tournamentSelector, mutator, fitnessCalculator, breeder, renderer);
            //god3.run();
            Simulator simulator = new Simulator(god, 100);
            simulator.simulate();

            Console.WriteLine("Number of specimens: " + god.getNumberOfSpecimens());

            DateTime timer2 = DateTime.Now;
            //Console.WriteLine("Time: " + (timer2 - timer));

            //TODO: Poolos selector, az a Breeder ahol szamit h milyen kozel van hozza + FitnessCalculator, Simulator, Tournament selector elitism
            //gene interface
            //geneben comparelni h mennyire vannak egymastol
            //
            /*
             * Problemak: Stringes, kepes, baratos (graf), fuggveny kozelites
             * new Specimen<StringGene<StringComparer>>()
             * 
             */
        }
    }
}
