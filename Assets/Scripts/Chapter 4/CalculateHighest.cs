using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateHighest : MonoBehaviour
{
    public float a = 5f;
    public float b = 8f;
    public float Highest;
    public float Lowest;


    // Start is called before the first frame update
    void Start()
    {
       Highest = CalculateMax(a, b);
       Debug.LogFormat(Highest + " Is Highest");

        Lowest = CalculateMin(a, b);
        Debug.LogFormat(Lowest + " Is lowest");

        CalculateEqual(a, b);
    }

    public float CalculateMax(float n, float m)
    {
        if (n >= m)
        {
            return n;
        }

        else
        {
            return m;
        }
    }

    public float CalculateMin(float c, float d)
    {
        if (c <= d)
        {
            return c;
        }

        else
        {
            return d;
        }
    }

    public void CalculateEqual(float e, float f)
    {
        if (e == f)
        {
            Debug.Log(" The numbers are equal");
        }
        else
        {
            Debug.Log(" The numbers are not equal");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
