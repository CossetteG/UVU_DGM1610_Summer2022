using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5ScopeAndAccess : MonoBehaviour
{
    public int alpha = 5;
    //this int can be used in any class and can be edited in the Inspector
    private int beta = 1;
    private int gamma = 3;
    //these ints are only for use within this class
    
    //Editing variable is initialization>declaration>inspector edit>function declaration>inspector edit after Start (resets)

    private AnotherClass myOtherClass;
    
    // Start is called before the first frame update
    //Not tested
    void Start()
    {
        alpha = 20;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens + crayons + alpha;
        Debug.Log(answer);
    }
    void Update()
    {
        bool Continue = false;

        do
        {
            Debug.Log("Alpha is set to " + alpha);
            Debug.Log("Beta is set to " + beta);
            Debug.Log("Gamma is set to " + gamma);
        } while (Continue == true);
    }
}
