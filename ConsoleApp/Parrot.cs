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

    public void MakeSound(string sound, bool mentionName, bool capitalize = false)
    {
        string chirp;

        if (mentionName)
        {
            chirp = Name + " chirps: " + sound;
        }
        else chirp = sound;

        Console.WriteLine(capitalize ? chirp.ToUpper() : chirp);
    }
}
