using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public abstract class Animal
    {
        public string Nickname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Energy { get; set; }
        public decimal Price { get; set; }
        public int MealQuantity { get; set; }

        public Animal(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }


        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();
    }
}
