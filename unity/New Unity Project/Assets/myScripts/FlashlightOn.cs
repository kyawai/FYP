using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightOn : MonoBehaviour
{
    public bool flashlightBut;
    public Light lt;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        lt.enabled = false;
    }

    void Update()
    {
        if (on == true)
        {
            lt.enabled = false;
            on = false;
        }
        else if (on == false)
        {
            lt.enabled = true;
            on = true;
        }
    }
}
