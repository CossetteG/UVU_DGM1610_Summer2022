using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3CoffeeTester : MonoBehaviour
{
    public float coffeeTemperature = 85.0f;
    public float hotLimitTemperature = 70.0f;
    public float coldLimitTemperature = 40.0f;
        

    // Update is called once per frame
    //not tested
    //I skipped the syntax lesson bc I know it already. stoopid
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        //too hot
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold");
        }
        else
        {
            print("Coffee is just right");
        }
    }
}
