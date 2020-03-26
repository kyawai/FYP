using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarySound : MonoBehaviour
{
    public GameObject sound;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        sound.SetActive(false);
    }

    void Update()
    {
        if (on == false)
        {
            on = true;
            sound.SetActive(true);
        }
        else if (on == true)
        {
            on = false;
            sound.SetActive(false);
        }
    }
}
