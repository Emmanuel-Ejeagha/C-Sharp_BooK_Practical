using System;

namespace Chpt14Classes;

public class AnimalsShelter
{
    private const int DefaultPlacesCount = 20;

    private Dog[] animalList;
    private int usedPlaces;

    public AnimalsShelter() : this(DefaultPlacesCount)
    {

    }

    public AnimalsShelter(int placesCount)
    {
        this.animalList = new Dog[placesCount];
        this.usedPlaces = 0;
    }

    public void Shelter(Dog newAnimal)
    {
        if (this.usedPlaces >= this.animalList.Length)
        {

            throw new InvalidOperationException("Shelter is full.");
        }
        this.animalList[this.usedPlaces] = newAnimal;
        this.usedPlaces++;
    }

    public Dog Release(int index)
    {
        if (index < 0 || index >= this.usedPlaces)
        {
            throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
        }
        Dog releaseAnimal = this.animalList[index];
        for (int i = index; i < this.usedPlaces - 1; i++)
        {
            this.animalList[i] = this.animalList[i + 1];
        }
        this.animalList[this.usedPlaces - 1] = null;
        this.usedPlaces--;

        return releaseAnimal;
    }
}
