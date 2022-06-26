using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Double : MonoBehaviour
{
    // Start is called before the first frame update
    //Not tested

    public int myInt = 5; 
    
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByTwo(int number)
    //"int" here tells this function to return an integer
    {
        int result;
        result = number * 2;
        return result;
    }
}
