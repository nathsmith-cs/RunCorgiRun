using UnityEngine;
using System.Collections;
public class BeerPlacer : TimedObjectPlacer
{

    void Start()
    {
        MinimumSecondsToWait = GameParameters.BeerMinimumSecondsToWait;
        MinimumSecondsToWait = GameParameters.BeerMaximumSecondsToWait;
    }
}
