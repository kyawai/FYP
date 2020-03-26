using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Flickering : MonoBehaviour
{
    public bool flickerBut;
    public Light lt;
    bool on = false;
    // Update is called once per frame
    void Start()
    {
        lt.enabled = false;
    }
    void Upate()
    {
        if (on == true)
        {
            lt.intensity = 0.0f;
            on = false;
        }
        else if (on == false)
        {
            on = true;
            lt.intensity = 5.0f;
            StartCoroutine(Flash());
        }
    }
    IEnumerator Flash()
    {
        while (on == true)
        {
            yield return new WaitForSeconds(0.25f);
            lt.enabled = !lt.enabled;
        }
    }
}
