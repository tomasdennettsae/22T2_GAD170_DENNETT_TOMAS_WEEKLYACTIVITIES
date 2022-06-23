using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4Activities : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Conversions();

        int currentyear = Random.Range(1752, 9999);
        Debug.Log("Year = " + currentyear);

        if (currentyear % 400 == 0)
        { 
            Debug.Log("yearisleapyear");
        }
            else
            {
                Debug.Log("Yearisnotleapyear");
            }
    }   

    // Hayden work
    void Conversions()
    {
        float Fahrenheit = 110f;
        float Celcius;
        Debug.Log("Temp in Fahrenheit " + Fahrenheit);

        //Determines the temp from fahrenheit to celcius
        Celcius = (Fahrenheit - 32) * 5 / 9;
        Debug.Log("Temp in Celcius " + Celcius);

        //Cool activity

        if (Celcius < 0)
        {
            Debug.Log("ITS FREEZING!!!!");
        }
        else
        {
            Debug.Log("its not freezing");
        }
  
    }

}
