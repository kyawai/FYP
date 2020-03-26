using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LightControl : MonoBehaviour
{
    public float slideLight;
    public Light lt;
    void Start()
    {
        slideLight = 1.0f;
        lt.intensity = slideLight;
    }
    void Update()
    {
        lt.intensity = slideLight;
    }
}
