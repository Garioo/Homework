using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMembers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindPartyMembers(0, "Marius Qvarnstrøm");
    }

    
    public void FindPartyMembers(int index, string name)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Jordan Larsson",
            "Rasmus Falk",
            "Elias Jelert",
            "Kamil Grabara"
     };
     
        QuestPartyMembers.Insert(0, name);

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
