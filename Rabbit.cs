using System;
using System.Collections.Generic;
using System.Text;

namespace Classroom
{

    class Rabbit
    {

        // Model the Rabbit class knowing that:
        //a rabbit can have Blue, Red or Black eyes
        //a rabbit's fur can be white, brown, black or grey
        //it has a gender
        //has a birth date, and based on that you should be able to see how old the rabbit is
        //we also know that a rabbit is a mammal that moves, sleeps and eats

        public string Eyes { get; set; }
        public string Fur { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }

        public int CurrentYear = 2019;

        public string Mammal { get; set; }
        public string Sleeps { get; set; }
        public string Eats { get; set; }


        public void GetRabbitInfo()
        {
            Console.WriteLine($"This rabbit have {this.Eyes} eyes and {this.Fur} fur. Rabbit gender is {this.Gender} and is {this.Age} years old. It is a {this.Mammal} that moves, sleeps and eats");
        }

        public int Age
        {
            get { return this.CurrentYear - this.BirthDate; }
        }


            
    }



}
