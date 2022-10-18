using System;
using System.Threading;

namespace genesis
{
    class Program
    {
        static void Main(string[] args)
        {
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
            

            string specimenZero = "retkes kurva isten faszat mar bazdmeg te mocskos budos retoroman csicska szar hogy baszna telibe a retkes kurva anyad isten fonjon kalacsot a faszodbol te rohadek kocsog cihany szar hogy folyjon ki a faszod leve a kurva picsadbol te retkes semmirekello fasznyalo nyomorult cigany fasz arab csoro majoma retkes kurva isten faszat mar bazdmeg te mocskos budos retoroman csicska szar hogy baszna telibe a retkes kurva anyad isten fonjon kalacsot a faszodbol te rohadek kocsog cihany szar hogy folyjon ki a faszod leve a kurva picsadbol te retkes semmirekello fasznyalo nyomorult cigany fasz arab csoro majoma retkes kurva isten faszat mar bazdmeg te mocskos budos retoroman csicska szar hogy baszna telibe a retkes kurva anyad isten fonjon kalacsot ";

            string fasz = "dogoljon meg az osszes mocskos retkes kurva geci cigany dogoljon meg az osszes mocskos retkes kurva geci cigany dogoljon meg az osszes mocskos";

            string test = "szia bazdmeg kutyaidat setaltatod";
            string asd = "a budos picsaba";

            God god = new God(2500, specimenZero, selector, mutator, fitnessCalculator, breeder, renderer);
            God god2 = new God(1000, fasz, poolSelector, mutator, exponentialFitnessCalculator, breeder, renderer);
            God god3 = new God(2500, specimenZero, tournamentSelector, mutator, fitnessCalculator, breeder, renderer);
            //god3.run();
            Simulator simulator = new Simulator(god, 100);
            simulator.simulate();

            Console.WriteLine("Number of specimens: " + god.getNumberOfSpecimens());

            DateTime timer2 = DateTime.Now;
            //Console.WriteLine("Fasz: " + (timer2 - timer));

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
