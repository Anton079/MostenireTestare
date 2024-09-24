using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireTestare.AbstarctizareExemplu
{
    public class ServicePerson : Action
    {
        private List<Person> persons;

        public ServicePerson()
        {
            persons = new List<Person>();
            LoadData();
        }

        public void LoadData()
        {
            persons.Add(new Student(1, "Anton", 16, true, 12, 9));
            persons.Add(new Teacher(2, "Laur", 35, false, 4000, "Info"));
            persons.Add(new Teacher(3, "Marius", 38, true, 4600, "Mate"));
            persons.Add(new Teacher(4, "Mario", 50, true, 6000, "Romana"));
            persons.Add(new Student(5, "Ionut", 15, false, 10, 7));
            persons.Add(new Student(6, "Anton", 14, true, 9, 4));
        }

        public override void AfisarePerson()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.PersonInfo());
            }
        }

        public override void EditarePresentPerson()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Cui id vrei sa ii editezi?");
                int idUserWAnted = int.Parse(Console.ReadLine());

                if (person.Id == idUserWAnted)
                {
                    Console.WriteLine($"Persoana cu id ul{person.Id} are ca prezenta{person.Present}, in ce vrei sa ii modifici?");

                    string wantedPresentToEdit = Console.ReadLine();

                    if (wantedPresentToEdit.Equals("true"))
                    {
                        person.Present = true;
                    }
                    else if (wantedPresentToEdit.Equals("false"))
                    {
                        person.Present = false;
                    }
                }
            }

        }

        public override void CheckWhosPresent()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Vrei sa vezi persoanele prezente sau absente?");
                string wanted = Console.ReadLine();

                if (wanted.Equals("Prezent"))
                {
                    Console.WriteLine(person.Present);
                }
            }
        }

    }
}
