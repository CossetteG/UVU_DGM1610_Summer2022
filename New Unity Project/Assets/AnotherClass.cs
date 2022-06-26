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
}
