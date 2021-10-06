using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Enemy
{

    protected override void shout()
    {
        Debug.Log("Animal");
    }
}