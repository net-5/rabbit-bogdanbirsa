using System;

//Model the Rabbit class knowing that:
//a rabbit can have Blue, Red or Black eyes
//a rabbit's fur can be white, brown, black or grey
//it has a gender
//has a birth date, and based on that you should be able to see how old the rabbit is
//we also know that a rabbit is a mammal that moves, sleeps and eats certain foods

namespace Classroom
{
    public enum EyeColors { Blue, Red, Black };
    public enum FurColors { White, Brown, Black, Grey };
    public enum Gender { Male, Female };
    public class Rabbit 
    {
        public string eyes;
        public string fur;
        private string gender;
        private DateTime birthDate;

        public Rabbit(string eyes, string fur, string gender, string birthDate)
        {
            Console.WriteLine((int)Gender.Female);
            if (String.Compare(gender, Gender.Female.ToString(), true) == 0)
            {
                this.gender = gender;
            }
            else
            {
                this.gender = "male";
            }
            if (String.Compare(eyes, EyeColors.Black.ToString(), true) == 0 || String.Compare(eyes, EyeColors.Blue.ToString(), true) == 0 || String.Compare(eyes, EyeColors.Red.ToString(), true) == 0)
            {
                this.eyes = eyes;
            }
            else
            {
                this.eyes = "no color";
            }
            if (String.Compare(fur, FurColors.Black.ToString(), true) == 0 || String.Compare(fur, FurColors.Brown.ToString(), true) == 0 || String.Compare(fur, FurColors.Grey.ToString(), true) == 0 || String.Compare(fur, FurColors.White.ToString(), true) == 0)
            {
                this.fur = fur;
            }
            else
            {
                this.fur = "no fur color";
            }
            this.birthDate = DateTime.Parse(birthDate);
        }

        public string Eyes
        {
            get { return this.eyes; }
        }
        public string Fur
        {
            get { return this.fur; }
        }
        public string GetAge()
        {
            int years = DateTime.Now.Subtract(this.birthDate).Days / 365;
            {
                return (years + " years ");
            }
        }
        public override string ToString()
        {
            return " Rabbit have "  + this.eyes + " eyes and his fur is " + this.fur
                + " . Gender is "  + this.gender + " and he is born in " + this.birthDate.ToShortDateString() + " , so he is "  + this.GetAge() + " old. " +
                "He is a mammal that jumps, sleeps and eats vegetables";
        }
    }
}


