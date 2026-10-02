using UnityEngine;
using System.Collections;
public class TimedObjectPlacer : MonoBehaviour
{
    //Corgi vomits beer million dollar idea
    
    public GameObject TimedObjectPrefab;

    public float  MinimumSecondsToWait;
    public float  MaximumSecondsToWait;
    
    private bool isOkToCreate = true;

    public void Update()
    {
        if (isOkToCreate)
        {
            StartCoroutine(CountdownUntilDeath());
        }
    }

    IEnumerator CountdownUntilDeath()
    {
        isOkToCreate = false;
        float secondsToWait = Random.Range(MinimumSecondsToWait, MaximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        isOkToCreate = true;
    }
    
    public void Place()
    {
        Instantiate(TimedObjectPrefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }



}
