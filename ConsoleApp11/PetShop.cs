using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class PetShop
    {
        
            public List<Cat> Cats { get; set; } = new List<Cat>();
            public List<Dog> Dogs { get; set; } = new List<Dog>();
            public List<Bird> Birds { get; set; } = new List<Bird>();
            

            public void AddCat(Cat cat)
            {
                Cats.Add(cat);
            }

            public void AddDog(Dog dog)
            {
                Dogs.Add(dog);
            }

            public void AddBird(Bird bird)
            {
                Birds.Add(bird);
            }

        
            public void RemoveByNickName(string nickname)
            {
                Cats.RemoveAll(c => c.Nickname == nickname);
                Dogs.RemoveAll(d => d.Nickname == nickname);
                Birds.RemoveAll(b => b.Nickname == nickname);
               
            }

            public int GetTotalCatMealQuantity()
            {
                return Cats.Sum(c => c.MealQuantity);
            }

            public decimal GetTotalCatPrice()
            {
                return Cats.Sum(c => c.Price);
            }


            public int GetTotalDogMealQuantity()
            {
                return Dogs.Sum(c => c.MealQuantity);
            }
            
            public decimal GetTotalDogPrice()
            {
                return Dogs.Sum(c => c.Price);
            }

            public int GetTotalBirdMealQuantity()
            {
                return Birds.Sum(c => c.MealQuantity);
            }
           
            public decimal GetTotalBirdPrice()
            {
                return Birds.Sum(c => c.Price);
            }
    }
}
