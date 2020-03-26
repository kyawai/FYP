using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource data;
    public bool sound = false;

    void Update()
    {
        if (sound)
        {
            if (!data.isPlaying)
            {
                data.Play();
                sound = false;
            }
        }
    }
}
