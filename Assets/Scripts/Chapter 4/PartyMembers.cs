
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMembers : MonoBehaviour
{
    public string myName = "Marius Qvarnstrøm";
    public int myNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        FindPartyMembers(myNumber, myName);
    }

    
    public void FindPartyMembers(int myNumber, string myName)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Jordan Larsson",
            "Rasmus Falk",
            "Elias Jelert",
            "Kamil Grabara"
        };
     
        QuestPartyMembers.Insert(myNumber, myName);

        int listLength = QuestPartyMembers.Count;

        Debug.LogFormat("Party Members: {0}", listLength);
        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == "Marius Qvarnstrøm")
            {
                Debug.Log("Welcome Marius Qvarnstrøm!");
            }
        }
    }
}
