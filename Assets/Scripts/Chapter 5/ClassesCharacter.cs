using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not Assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintCharacterInfo()
    {
        Debug.LogFormat("Hero; {0} - {1} EXP", this.name, this.exp);
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;

    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon; {0} - {1} DMG", this.name, this.damage);
    }

}

public class Paladin: Character
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon): base(name)
    {
        this.weapon = weapon;
    }
    public override void PrintCharacterInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name, this.weapon.name);
    }
}
