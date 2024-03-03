using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorKout
{
    internal class SetBL
    {
        private int Repetitions;
        private float Efforts;

        public SetBL(int reps, float efforts)
        {
            Repetitions = reps;
            Efforts = efforts;
        }

        public void SetRepitition(int repetitions)
        {
            Repetitions = repetitions;
        }

        public int GetRepetitions()
        {
            return Repetitions;
        }

        public void SetEfforts(float efforts)
        {
            Efforts = efforts;
        }

        public float Gwtefforts()
        {
            return Efforts;
        }

    }

}
