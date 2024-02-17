using System;
using System.Collections.Generic;
using System.Text;

namespace genesis.Model
{
    class StringGene : Gene
    {
        private string gene;

        public StringGene(String gene)
        {
            this.gene = gene;
        }

        public int compareTo(Gene gene)
        {
            throw new NotImplementedException();
        }

        public int getLength()
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }
    }
}
