using UnityEngine;
using System.Collections;

public class Orc : Humanoid
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}