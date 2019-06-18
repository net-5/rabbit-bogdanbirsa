using System;

namespace Classroom
{

    // Model the Rabbit class knowing that:
    //a rabbit can have Blue, Red or Black eyes
    //a rabbit's fur can be white, brown, black or grey
    //it has a gender
    //has a birth date, and based on that you should be able to see how old the rabbit is
    //we also know that a rabbit is a mammal that moves, sleeps and eats

    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.Eyes = "red";
            rabbit.Fur = "white";
            rabbit.Gender = "male";
            rabbit.BirthDate = 2017;
            rabbit.Mammal = "mammal";
            rabbit.Sleeps = "sleeps";
            rabbit.Eats = "eats";
            rabbit.GetRabbitInfo();
            Console.WriteLine(rabbit.Age);

        }

    }
}
