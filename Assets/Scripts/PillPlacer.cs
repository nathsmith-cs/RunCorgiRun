using UnityEngine;

public class PillPlacer : TimedObjectPlacer
{
    public void Start()
        {
            MinimumSecondsToWait = GameParameters.PillMinimumSecondsToWait;
            MinimumSecondsToWait = GameParameters.PillMaximumSecondsToWait;
        }
}
