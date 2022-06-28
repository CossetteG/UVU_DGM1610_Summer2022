using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass 
{
    public int apples = 6;
    public int bananas;

    private int stapler;
    private int tape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total is" + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a * b;
        Debug.Log("Office Supplies total: " + answer);
    }
    
    //linear interpolation: 4
    private float result = Mathf.Lerp(3f, 5f, 0.5f);
    //can be used with float, color, and vector3 values
    //to fade something
    //light.intensity obj = Mathf.Lerp(light.intensity, 8f, 0.4f*Time.deltaTime);
    //but it may be better to use SmoothDamp function
}
