using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessPower.Models.Exercises
{
    public abstract class Exercise
    {
        public int ExerciseTypeId { get; set; }
        public string ExerciseName { get; set; }
    }
}
