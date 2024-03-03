using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    internal class SubjectDL
    {   public static List<SubjectBL> allsubjects = new List<SubjectBL>();
        public static void SaveSubjectRecords(string path, SubjectBL d)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(d.code + "," + d.type + "," + d.creditHours + "," + d.subjectFees);
            file.Flush();
            file.Close();

        }
        public static bool ReadFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectFees = int.Parse(splittedRecord[3]);
                    SubjectBL s = new SubjectBL(code, type, creditHours, subjectFees);
                    AddSubjectIntoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddSubjectIntoList(SubjectBL s) {

            allsubjects.Add(s);
        }
    }
}
