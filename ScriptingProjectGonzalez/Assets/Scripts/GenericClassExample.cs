using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //In order to create an object of a generic class, you must
        //specify the type you want the class to have.
        GenricClass<int> myClass = new GenricClass<int>();

        myClass.UpdateItem(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
