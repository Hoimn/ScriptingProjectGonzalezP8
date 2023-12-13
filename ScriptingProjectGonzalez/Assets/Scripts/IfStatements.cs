using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTempature = 70.0f;
    float coldLimitTempature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        //If tthe coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTempature)
        {
            //...do this.
            print("Coffee is too hot.");
        }
        //If it isn't, but the coffee temperature is less than the coldest drinking tempature
        else if(coffeeTemperature < coldLimitTempature)
        {
            //...do this.
            print("Coffee is too cold.");
        }
        //If it is neither of those then...
        else
        {
            //...do this.
            print("Coffee is just right");
        }
    }
}
