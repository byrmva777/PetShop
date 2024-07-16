using ConsoleApp11;

class Program
{
    public static void Main (string[] args)
    {
        PetShop petShop = new PetShop();

        Cat cat1 = new Cat("Tom", 2, "Male", 20, 150.0m, 0);
        Dog dog1 = new Dog("Maks", 3, "Male", 25, 120.0m, 0);
        Bird bird1 = new Bird("Bulbul",4, "Male", 10, 110.0m, 0);
        

        petShop.AddCat(cat1);
        petShop.AddDog(dog1);
        petShop.AddBird(bird1);

        cat1.Play();
        cat1.Eat();
        dog1.Play();
        dog1.Eat();
        bird1.Play();
        bird1.Eat();

        Console.WriteLine($"Total cat meal quantity: {petShop.GetTotalCatMealQuantity()}");
        Console.WriteLine($"Total cat price: {petShop.GetTotalCatPrice()}");
        Console.WriteLine($"Total dog price: {petShop.GetTotalDogPrice()}");
        Console.WriteLine($"Total bird price: {petShop.GetTotalBirdPrice()}");

        petShop.RemoveByNickName("Tom");
        petShop.RemoveByNickName("Reks");
        petShop.RemoveByNickName("Bulbul");

        Console.WriteLine($"Total cat meal quantity after removal: {petShop.GetTotalCatMealQuantity()}");
        Console.WriteLine($"Total cat price after removal: {petShop.GetTotalCatPrice()}");
        Console.WriteLine($"Total dog meal quantity after removal: {petShop.GetTotalDogMealQuantity()}");
        Console.WriteLine($"Total dog price after removal: {petShop.GetTotalDogPrice()}");
        Console.WriteLine($"Total bird meal quantity after removal: {petShop.GetTotalBirdMealQuantity()}");
        Console.WriteLine($"Total bird price after removal: {petShop.GetTotalBirdPrice()}");
    }

}