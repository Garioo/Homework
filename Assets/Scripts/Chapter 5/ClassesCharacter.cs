using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;
    public int defaultExp = 100; //Declared default Exp too 100
    

    public Character()
    {
        name = "Not Assigned";
        this.exp = defaultExp;
    }

    public Character(string name)
    {
        this.name = name;
    }

    public Character(string name, int exp)
    {
        this.name = name;
        this.exp = defaultExp; //Never write number in code - Declare it
    }

    public virtual void PrintCharacterInfo()
    {
        Debug.LogFormat("Hero; {0} - {1} EXP", this.name, this.exp);
    }

    public virtual void PrintVillanInfo()
    {
        Debug.LogFormat("Villan; {0} - {1} EXP", this.name, this.exp);
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

    public Paladin(string name, int exp, Weapon weapon) : base(name, exp)
    {
        this.weapon = weapon;
        
    }
    public override void PrintCharacterInfo()
    {
        Debug.LogFormat("Hail {0} ({1}) - take up your {2}!", name, this.exp, weapon.name);
    }
}
