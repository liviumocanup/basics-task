public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " roared.");
    }

    public void MakeSound(int times)
    {
        Console.Write(Name + " purrs: ");
        for (int i = 0; i < times; i++)
        {
            Console.Write("purr... ");
        }
        Console.WriteLine();
    }
}
