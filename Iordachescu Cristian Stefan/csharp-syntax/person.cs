namespace csharp_syntax
{
    internal class person
    {
        private string name;
        private int age;

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string name)
        //{
        //    this.name = name;
        //}

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
        }
    }
}
