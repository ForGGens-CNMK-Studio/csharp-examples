using System.Diagnostics;

namespace csharp_syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person("John", 30);

            p.SayHello();

            p.Name = "Jane";
            p.Age = 25;

            p.SayHello();

            Console.WriteLine("Name: " + p.Name);

            person[] people = GeneratePeople(5);
            foreach (person person in people)
            {
                person.SayHello();
            }
            // compare with simple for
            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i].SayHello();
            //}
        }

        static public person[] GeneratePeople(int n)
        {
            person[] people = new person[n];

            for (int i = 0; i < n; i++)
            {
                people[i] = new person("Person " + i, i);
            }

            return people;
        }
    }
}
