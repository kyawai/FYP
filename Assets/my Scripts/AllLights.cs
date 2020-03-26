using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLights : MonoBehaviour
{
    public float lightSlider;
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    void Start()
    {
        lightSlider = 10.0f;
    }
    void Update()
    {
        light1.intensity = lightSlider;
        light2.intensity = lightSlider;
        light3.intensity = lightSlider;
        light4.intensity = lightSlider;
    }
}
