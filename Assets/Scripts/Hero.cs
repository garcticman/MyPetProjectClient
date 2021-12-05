using System;
using UnityEditor;
using UnityEngine;

public class Hero
{
    public readonly string Name;
    protected float _attack;
    protected float _health;

    public Hero(string name, float attack, float health)
    {
        Name = name;
        _attack = attack;
        _health = health;
    }

    public void Attack(Hero anotherHero)
    {
        anotherHero.Hit(_attack);
        Debug.Log(string.Format("Герой {0} атакует героя {1}", Name, anotherHero.Name));
    }

    public void Hit(float damage)
    {
        _health -= damage;
    }
}