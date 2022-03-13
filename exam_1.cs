using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount;
            string eachName;
            string eachAge;
            
            List<Person> people = new List<Person>() {};
            List<Yo> age = new List<Yo>() {};

            amount = Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i<amount; i++) {
            eachName = Console.ReadLine();
            people.Add(new Person (eachName ));
 
            eachAge = Console.ReadLine();
            age.Add(new Yo (eachAge ));

            Console.WriteLine("{0}. {1} is {2} yo", (i+1), people[i].Name, age[i].Age);
        }
        }
    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    class Yo
    {
        public string Age { get; }
        public Yo(string age) => Age = age;
    }
}
