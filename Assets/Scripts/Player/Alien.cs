using UnityEngine;

public abstract class Alien
{
    public string Name { get; private set; }

    public Alien(string name)
    {
        Name = name;
    }

    public abstract void ExecuteAbility(Rigidbody2D rigidbody2D);
}