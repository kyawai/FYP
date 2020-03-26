using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject water;
    public bool pick;
    public bool colour;
    void Start()
    {
        pick = false;
        water.SetActive(false);
        colour = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pick)
        {
            water.SetActive(true);
        }
        if(!pick)
        {
            water.SetActive(false);
        }
    }
}
