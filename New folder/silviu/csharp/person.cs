﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp
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
            get
            {
                return name;
            }
            set { name = value; }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set { age = value; }
        }
        public void SayHello()
        {
            Console.WriteLine(" Hello my name is " + name + " and I am " + age + " years old.");
        }
    }
}