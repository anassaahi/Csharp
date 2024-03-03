using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout
{
    internal class WorkoutRoutineBL
    {
        private string Name;
        private List<ExersiceBL> Exercises;

        public WorkoutRoutineBL(string name, List<ExersiceBL> Exercises)
        {
            Name = name;
            this.Exercises = Exercises;

        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void AddExerciseInWork(ExersiceBL e)
        {
            Exercises.Add(e);
        }

        public void SetExerciseInWork(List<ExersiceBL> Exercises)
        {
            this.Exercises = Exercises;
        }

        public List<ExersiceBL> GetExerciseSets()
        {
            return this.Exercises;
        }


    }
}
