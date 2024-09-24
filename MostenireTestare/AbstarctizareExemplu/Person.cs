using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class Person : Action
    {
        private int _id;
        private string _name;
        private int _age;
        private bool _present;


        public Person(int id, string name, int age, bool present)
        {
            _id = id;
            _name = name;
            _age = age;
            _present = present;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Present
        {
            get { return _present; }
            set { _present = value; }
        }

        public override void AfisarePerson()
        {

        }

        public override void EditarePresentPerson()
        {

        }

        public override void CheckWhosPresent()
        {

        }

        public string PersonInfo()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Age" + Age + '\n';
            text += "Present " + Present + "\n";
            return text;
        }
    }
}
