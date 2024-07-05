using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziua2
{
    internal class persoana
    {
        private string name;
        private int age;

        public persoana( string name, int age)
        {
            this.name = name;
            this.age = age;

        }
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
    
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void SayHello()
        {
            Console.WriteLine( "Hello, my name is" + name + " and I am " + age + " years old");
        }

    
    }

}
