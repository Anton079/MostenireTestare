using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class Teacher : Person
    {
        private int _salary;
        private string _profil;

        public Teacher(int id, string name, int age, bool present, int salary, string profil) : base(id, name, age, present)
        {
            _salary = salary;
            _profil = profil;
        }

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Profil
        {
            get { return _profil; }
            set { _profil = value; }
        }

        public string PersonInfo()
        {
            string text = base.PersonInfo();

            text += "Salary " + Salary + "\n";
            text += "Profil " + Profil + '\n';
            return text;
        }
    }
}
