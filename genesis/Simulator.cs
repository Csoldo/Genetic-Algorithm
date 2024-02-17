using System;
using System.Collections.Generic;
using System.Text;

namespace genesis
{
    class Simulator
    {
        private God god;
        private int simulationCount;
        


        public Simulator(God god, int simulationCount)
        {
            this.god = god;
            this.simulationCount = simulationCount;
        }

        public void simulate()
        {
            Console.WriteLine("START");
            DateTime timer = DateTime.Now;
            for (int i = 0; i < simulationCount; i++)
            {
                god.run();
                Console.WriteLine("Currently running simulation:  " + i);
                god.reset();
                //TODO kiszedni a godbol a cuccokat
            }
            DateTime timer2 = DateTime.Now;
            Console.WriteLine("Runtime avarage: " + ((timer2 - timer) / simulationCount));
            Console.WriteLine("Total runtime: " + (timer2 - timer) +  "  ------   " + simulationCount +  " times.");
        }
    }
}
