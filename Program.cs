﻿using System;

namespace Classroom
{

    // Model the Rabbit class knowing that:
    //a rabbit can have Blue, Red or Black eyes
    //a rabbit's fur can be white, brown, black or grey
    //it has a gender
    //has a birth date, and based on that you should be able to see how old the rabbit is
    //we also know that a rabbit is a mammal that moves, sleeps and eats

 public class Program
    {
        public static void Main(string[] args)
        {
            Rabbit animal = new Rabbit("blue", "Black", "female", "01,01,2016");
            Console.WriteLine(animal);
        }
    }
}
