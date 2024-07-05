using System.IO.Pipes;

namespace ziua2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persoana p = new persoana(" joe ", 20);

            p.SayHello();

            p.Name = " Candice ";
            p.Age = 23;

            p.SayHello();

            Console.WriteLine(" Name " + p.Name);

            persoana[] people = GeneratePeople(5);
            foreach (persoana  persoana in people)
            {
                persoana.SayHello()
;            }

            //for( int i=0; i< people.Length; i++)
            //{
            //   people[i].SayHello();
            //}
         }

        static public persoana[] GeneratePeople(int n)
        {
            persoana[] people = new persoana[n];

            for(int i=0; i< n; i++)
            {
                people[i] = new persoana(" Persoana " + i, i);
             }

            return people;
        }
    }
}
