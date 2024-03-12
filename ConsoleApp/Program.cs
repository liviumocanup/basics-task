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

Animal leo = lion.Clone() as Animal;
if (leo is not null)
{
    leo.Name = "Leo Jr.";
    Console.WriteLine($"Clone {leo}");
    Console.WriteLine(lion);
}

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

Console.WriteLine("=====================================");

System.Collections.IEnumerator enumerator = myZoo.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current as Animal);
}
