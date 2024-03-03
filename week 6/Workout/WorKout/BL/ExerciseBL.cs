using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class ExerciseBL
    {
        private string Name;
        private List<SetBL> SetsOfExersices;

        public ExerciseBL(string name, List<SetBL> exerciseSets)
        {
            Name = name;
            SetsOfExersices = exerciseSets;
        }
        public ExerciseBL(string name)
        {
            Name=name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void AddExerciseSet(SetBL s)
        {
            SetsOfExersices.Add(s);
        }

        public void SetExerciseSets(List <SetBL> sets)
        {
            this.SetsOfExersices = sets;
        }

        public List<SetBL> GetExerciseSets()
        {
            return this.SetsOfExersices;
        }


    }
}
