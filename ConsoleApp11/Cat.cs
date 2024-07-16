using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public  class Cat : Animal
    {
        public Cat(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
      : base(nickname, age, gender, energy, price, mealQuantity) { }

        private const int EnergyIncrement = 10;
        private const int EnergyDecrement = 10;
        private const decimal PriceIncrement = 100.0m;
        public override void Eat()
        {
            Energy += EnergyIncrement;
            MealQuantity += 1;
            Price += PriceIncrement;
        }

        public override void Sleep()
        {
            Energy += EnergyIncrement * 2;
        }

        public override void Play()
        {
            Energy -= EnergyDecrement;
            if (Energy <= 0)
            {
                Energy = 0;
                Sleep();
            }
        }
    }
}
