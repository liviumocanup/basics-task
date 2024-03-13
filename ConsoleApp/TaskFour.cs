public class TaskFour
{
    public static void Run()
    {
        Lion lion = new Lion("Leo", 3);
        Animal? leo = lion.Clone() as Animal;

        if (leo is not null)
        {
            leo.Name = "Leo Jr.";
            Console.WriteLine($"Clone {leo}");
            Console.WriteLine(lion);
        }
        else
        {
            Console.WriteLine("Leo is null.");
        }

        Console.WriteLine("=====================================");

        Parrot parrot = new Parrot("Polly", 2);
        parrot.MakeSound("Hello", true);
        parrot.MakeSound(mentionName: true, sound: "Hi");
        parrot.MakeSound(mentionName: false, sound: "Chirp chirp", capitalize: true);
    }
}