using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass1
{
    public T GenricMethod<T>(T param) where T : struct
    {
        return param;
    }
}
