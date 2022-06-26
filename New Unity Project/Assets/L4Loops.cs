using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L4Loops : MonoBehaviour
{
    public int numEnemies = 3;
    public int cupsInTheSink = 4;
    
    // Start is called before the first frame update
    //4 different loops
    //not tested
    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number " + i);
        }
        
        while(cupsInTheSink > 0)
        {
             Debug.Log ("I've washed a cup!");
             cupsInTheSink--;
        }
        
        bool shouldContinue = false;

        do
        {
            print ("Hello World");
            
        }while(shouldContinue == true);
        
        string[] pencils = new string[3];
        
        pencils[0] = "Red Pencil";
        pencils[1] = "Green Pencil";
        pencils[2] = "Yellow Pencil";

        foreach (string item in pencils)
        {
            print (item);
        }

    }   
}
