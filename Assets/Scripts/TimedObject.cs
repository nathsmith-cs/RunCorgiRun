using UnityEngine;
using System.Collections;

public class TimedObject : MonoBehaviour
{
    public float secondsOnScreen = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        StartCoroutine(CountdownUntilDeath());
    }

    // Update is called once per frame
    IEnumerator CountdownUntilDeath()
    {
        yield return new WaitForSeconds(secondsOnScreen);
        Destroy(gameObject);
    }
}
