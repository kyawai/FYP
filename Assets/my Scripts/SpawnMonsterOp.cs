using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterOp : MonoBehaviour
{
    public bool on = false;
    public GameObject monster;


    void Update()
    {
        if (on)
        {
            monster.SetActive(true);

        }
        if (!on)
        {
            monster.SetActive(false);

        }

    }
}
