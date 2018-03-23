using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessPower.Models.Exercises
{
    public class BenchPress : Exercise
    {
        private Tuple<int, int> _maxRepsAndWeight;

        public Tuple<int, int> MaxRepsAndWeight
        {
            get { return _maxRepsAndWeight; }
        }

        public BenchPress(int maxReps, int maxWeight)
        {
            _maxRepsAndWeight = new Tuple<int, int>(maxReps, maxWeight);
        }
    }
}
