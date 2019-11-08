using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga
{
    public class Сhromosome
    {
        public Сhromosome(double val, double fitnessVal)
        {
            this.value = val;
            this.fitness = fitnessVal;
            this.isDead = false;
        }
        public double value { get; private set; }
        public double fitness { get; private set; }
        public bool isDead { get; set; }
    }
}
