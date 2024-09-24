using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class Student : Person
    {
        private int _clas;
        private int _skill;

        public Student(int id, string name, int age, bool present, int clas, int skill) : base(id, name, age, present)
        {
            _clas = clas;
            _skill = skill;
        }

        public int Class
        {
            get { return _clas; }
            set { _clas = value; }
        }

        public int Skill
        {
            get { return _skill; }
            set { _skill = value; }
        }

        public string PersonInfo()
        {
            string text = base.PersonInfo();

            text += "Class" + Class + "\n";
            text += "Skill " + Skill + "\n";
            return text;


        }
    }
}
