using System.Collections;

public class Zoo : IEnumerable
{
    private List<Animal> _animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public IEnumerator GetEnumerator()
    {
        foreach (var animal in _animals)
        {
            yield return animal;
        }
    }
}
