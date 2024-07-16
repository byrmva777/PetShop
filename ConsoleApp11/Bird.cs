using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Bird : Animal
    {
        public Bird(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat() { }
        public override void Sleep() { }
        public override void Play() { }

    }
}
