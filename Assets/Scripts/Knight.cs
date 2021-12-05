using UnityEngine;

public class Knight : Hero
{
    public Knight(string name, float attack, float health) : base(name, attack, health)
    {
        
    }

    public void Attack(Hero anotherHero)
    {
        anotherHero.Hit(_attack);
        Debug.Log(string.Format("Герой {0} атакует мечом героя {1}", Name, anotherHero.Name));
    }
}