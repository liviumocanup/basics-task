public class Parrot : Animal
{
    public Parrot(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine(Name + " chirped.");
    }

    public void MakeSound(string sound)
    {
        Console.WriteLine(Name + " chirps: " + sound);
    }
}
