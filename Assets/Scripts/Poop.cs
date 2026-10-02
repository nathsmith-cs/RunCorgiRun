using System.Collections;
using UnityEngine;

public class Poop : TimedObject
{
    public void Start()
    {
        secondsOnScreen = GameParameters.poopSecondsOnScreen;
        base.Start();
    }
}
