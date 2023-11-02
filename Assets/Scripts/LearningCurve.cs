using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;
    // Start is called before the first frame update
    void Start()
    {
        CamTransform = this.GetComponent<Transform>();
        //DirectionLight = GameObject.Find("Directional Light");
        Debug.Log(CamTransform.localPosition);

        //Weapons

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

        Weapon warBow = huntingBow;
            warBow.name = "War Bow";
            warBow.damage = 155;
            warBow.PrintWeaponStats();

             
        //Characters

        Character hero = new Character();
        hero.PrintCharacterInfo();

        Character heroine = new Character("Lagatha");
        heroine.PrintCharacterInfo();

        Character villain = hero;
        villain.name = "Neville Longbottom";
        villain.PrintCharacterInfo();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintCharacterInfo();

        
    }

    // Update is called once per frame
}
