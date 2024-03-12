using System;

public abstract class Animal : ICloneable
{
    private int _age;

    public string Name { get; set; }
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative");
            }
            else _age = value;
        }
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public sealed override string ToString()
    {
        return $"Animal {Name} of type {GetType().Name} is {Age} years old";
    }
}