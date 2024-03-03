using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.DL;
using UAMS.UI;

namespace UAMS.BL
{
    internal class DegreeProgramBL
    {
        public string degreeName;
        public float degreeDuration;
        public List<SubjectBL> subjects;
        public int places;

        public DegreeProgramBL(string degreeName, float degreeDuration, int places)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.places = places;
            subjects = new List<SubjectBL>();
        }

        public int CalcualateCreditHours()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].creditHours;
            }
            return count;
        }

        public bool AddSubject(SubjectBL s)
        {   
            int creditHours = CalcualateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                SubjectDL.SaveSubjectRecords("subject.txt", s);
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DoesSubjectExists(SubjectBL sub)
        {
            foreach (SubjectBL s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
