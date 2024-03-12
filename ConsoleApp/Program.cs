Lion lion = new Lion("Leo", 3);
lion.MakeSound();
lion.MakeSound(3);
Console.WriteLine(lion);
try 
{
  lion.Age = -1;
}
catch (ArgumentOutOfRangeException e)
{
  Console.WriteLine(e.Message);
}

Console.WriteLine("=====================================");

Parrot parrot = new Parrot("Polly", 2);
parrot.MakeSound();
parrot.MakeSound("I'm a parrot");
Console.WriteLine(parrot);

Console.WriteLine("=====================================");

Zoo myZoo = new Zoo();
myZoo.AddAnimal(new Lion("Simba", 3));
myZoo.AddAnimal(new Parrot("Coco", 5));
myZoo.AddAnimal(lion);
myZoo.AddAnimal(parrot);

foreach (Animal animal in myZoo)
{
    Console.WriteLine(animal.ToString());
}

