using UnityEngine;

public class BonePlacer : TimedObjectPlacer
{

    public void Start()
    {
        MinimumSecondsToWait = GameParameters.BoneMinimumSecondsToWait;
        MinimumSecondsToWait = GameParameters.BoneMaximumSecondsToWait;
    }



}
