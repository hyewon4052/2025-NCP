﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample32
{
    internal class Program
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent() : ");
            }
            public Parent(int n)
            {
                Console.WriteLine("Parent(int param)");
            }
            public Parent(string name)
            {
                Console.WriteLine("Parent(string param) ");
            }
        }
        class Child : Parent
        {
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child (string input) : base(input)");
            }
            static void Main(string[] args)
            {
                Child childA = new Child();
                Child childB = new Child("string");
            }
        }
    }
}