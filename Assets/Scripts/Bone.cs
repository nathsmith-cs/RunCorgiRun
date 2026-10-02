using UnityEngine;

public class Bone : TimedObject
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        secondsOnScreen = GameParameters.BoneSecondsOnScreen;
        base.Start();
    }

    
}
