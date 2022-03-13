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
            int eachGrade;
            
            List<Person> person = new List<Person>() {};
            List<Yo> age = new List<Yo>() {};
            List<Gr> grade = new List<Gr>() {};

            amount = Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i<amount; i++) {
                eachName = Console.ReadLine();
                person.Add(new Person (eachName));
                eachAge = Console.ReadLine();
                age.Add(new Yo (eachAge));
                eachGrade = Convert.ToInt32(Console.ReadLine());
                grade.Add(new Gr (eachGrade));
                Console.WriteLine("{0}. {1} is {2} yo. Grade is {3}", (i+1), person[i].Name, age[i].Age, grade[i].Grade );
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
    class Gr
    {
        public int Grade { get; }
        public Gr(int grade) => Grade = grade;
    }
}
