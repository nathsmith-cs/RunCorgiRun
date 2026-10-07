using System;
using UnityEngine;

public class Pill : TimedObject
{
   private void Start()
   {
      secondsOnScreen = GameParameters.PillSecondsOnScreen;
      base.Start();
   }
}
