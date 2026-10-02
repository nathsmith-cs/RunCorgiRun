using System.Collections;
using UnityEngine;

public class Beer : TimedObject
{
    public void Start()
    {
        secondsOnScreen = GameParameters.beerSecondsOnScreen;
        base.Start();
    }
}
