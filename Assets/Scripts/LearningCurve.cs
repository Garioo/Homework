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

        // Name + List of parameters = Signature of the method

        Character hero = new Character();
		hero.PrintCharacterInfo();

		Character heroine = new Character("Lagatha", 6);
		Character experinceHeroine = new Character("Grogu", 15);

		experinceHeroine.PrintCharacterInfo();
		heroine.PrintCharacterInfo();

		Character villain = hero;
		villain.name = "Darth Vader";
		villain.PrintVillanInfo();

		Paladin knight = new Paladin("Sir Arthur",9, huntingBow);
		knight.PrintCharacterInfo();

		
	}

	// Update is called once per frame
}
