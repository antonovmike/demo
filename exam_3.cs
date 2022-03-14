using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
    {
        public string Name;
        public string Age { get; }
        public Person(string name, string age) => (Name, Age) = (name, age);
    }
class Mt
    { public int Math { get; }
    public Mt(int math) => Math = math; }
class Rl
    { public int Rulang { get; }
    public Rl(int rulang) => Rulang = rulang; }
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
        List<Mt> math = new List<Mt>() {};
        List<Rl> rulang = new List<Rl>() {};
            
        Console.WriteLine("Enter number of students");
        amount = Convert.ToInt32(Console.ReadLine());
            
        for (int i=0; i<amount; i++) {
            Console.WriteLine("Enter a name:");
            eachName = Console.ReadLine();
            Console.WriteLine("Enter an age:");
            eachAge = Console.ReadLine();
            name.Add(new Person (eachName, eachAge));
            age.Add(new Person (eachName, eachAge));
            Console.WriteLine("Enter math grade:");
            eachMath = Convert.ToInt32(Console.ReadLine());
            math.Add(new Mt (eachMath));
            Console.WriteLine("Enter Russian language grade:");
            eachRulang = Convert.ToInt32(Console.ReadLine());
            rulang.Add(new Rl (eachRulang));
        }

        for (int i=0; i<amount; i++) {
            Console.WriteLine("{0}. {1} is {2} yo. Math {3}, Russian language {4}", 
            (i+1), name[i].Name, age[i].Age, math[i].Math, rulang[i].Rulang);
        }
    }
}
