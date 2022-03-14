using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
    {
        public string Name;
        public string Age { get; }
        public int Math { get; }
        public int Rulang { get; }
        public Person(string name, string age, int math, int rulang) => (Name, Age, Math, Rulang) = (name, age, math, rulang);
    }
class Program
    {
    static void Main(string[] args)
    {
        int amount;
        string eachName;
        string eachAge;
        int eachMath;
        int eachRulang;

        List<Person> name = new List<Person>() {};
        List<Person> age = new List<Person>() {};
        List<Person> math = new List<Person>() {};
        List<Person> rulang = new List<Person>() {};
            
        Console.WriteLine("Enter number of students");
        amount = Convert.ToInt32(Console.ReadLine());
// ВВОД ДАННЫХ
        for (int i=0; i<amount; i++) {
            Console.WriteLine("Enter a name:");
            eachName = Console.ReadLine();
            Console.WriteLine("Enter an age:");
            eachAge = Console.ReadLine();
            Console.WriteLine("Enter math grade:");
            eachMath = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Russian language grade:");
            eachRulang = Convert.ToInt32(Console.ReadLine());
            name.Add(new Person (eachName, eachAge, eachMath, eachRulang));
            age.Add(new Person (eachName, eachAge, eachMath, eachRulang));
            math.Add(new Person (eachName, eachAge, eachMath, eachRulang));
            rulang.Add(new Person (eachName, eachAge, eachMath, eachRulang));
        }
// ВЫВОД РЕЗУЛЬТАТА
        for (int i=0; i<amount; i++) {
            Console.WriteLine("{0}. {1} is {2} yo. Math {3}, Russian language {4}", 
            (i+1), name[i].Name, age[i].Age, math[i].Math, rulang[i].Rulang);
        }
    }
}

