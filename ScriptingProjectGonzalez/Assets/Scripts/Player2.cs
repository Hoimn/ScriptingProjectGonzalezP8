using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a class. 
    public static int playerCount = 0;

    void Start()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        playerCount++;
    }
}
