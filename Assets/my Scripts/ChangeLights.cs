using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLights : MonoBehaviour
{
    public float lightSlider;
    public Light lights;

    void Start()
    {
        lightSlider = 1.0f;
    }
    void Update()
    {
        lights.intensity = lightSlider;
    }
}
