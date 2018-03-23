using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessPower.Models.Exercises
{
    public class Run : Exercise
    {
        private float _distance;
        private DateTime _time;

        public float Distance
        {
            get { return _distance; }
        }

        public DateTime Time
        {
            get { return _time; }
        }

        public Run(float distance, DateTime time)
        {
            _distance = distance;
            _time = time;
        }
    }
}
