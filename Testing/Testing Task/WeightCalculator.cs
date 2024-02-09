using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTask
{
    public class WeightCalculator
    {
        public double Height { get; set; }

        public char Gender { get; set; }

        public double GetWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);

                case 'f':
                    return (Height - 100) - ((Height - 150) / 2);

                default:
                    return 0;

            }
        }
    }
}
