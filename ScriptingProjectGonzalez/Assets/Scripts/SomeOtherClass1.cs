using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass1 myClass = new SomeClass1();

        myClass.GenricMethod<int>(5);
    }
}
