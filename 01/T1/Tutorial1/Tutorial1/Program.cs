﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
namespace Tutorial1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Animal animal=new Animal();
            animal.animalSound();
           Console.ReadKey();
        }
    }
}
