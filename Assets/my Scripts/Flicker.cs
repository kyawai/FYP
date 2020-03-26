using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    public bool flicker;
    public bool on;
    public Light deskLight;
    float min = 3.8f;
    float max = 4.1f;
    float timer;
    float randomFlashed;

    void Start()
    {
        randomFlashed = Random.Range(min, max);

    }

    // Update is called once per frame
    void Update()
    {
        if (on && flicker == false)
        {
            deskLight.enabled = true;
        }
        if (flicker && on)
        {
            StartCoroutine(FlashCoroutine());
        }
        if (!on)
        {
            deskLight.enabled = false;
        }
    }
    IEnumerator FlashCoroutine()
    {
        deskLight.enabled = true;
        yield return new WaitForSeconds(randomFlashed);
        deskLight.enabled = false;
        yield return new WaitForSeconds(randomFlashed);
    }
}