using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkoutRoutineBL monday = new WorkoutRoutineBL("Sunday");
            monday.AddExerciseInWork("Running");

            SetBL twelve = new SetBL(11, 99);

            ExerciseBL e = new ExerciseBL("Jogging");

        }
    }
}
