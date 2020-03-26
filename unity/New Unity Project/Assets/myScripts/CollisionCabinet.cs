using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCabinet : MonoBehaviour
{
    private bool Touching = false;

    private bool closing = false;
    private bool opening = false;
    private float movement = 1.0f;
    private float counter = 94.0f;
    public GameObject cabinet;
    void Start()
    {
        if (counter < 95)
        {
            opening = true;
        }
    }
    void Update()
    {
        if (Touching)
        {
                if (opening)
                {
                    cabinet.transform.Rotate(0, movement, 0, Space.World);
                    counter = counter + movement;
                    if (counter > 180)
                    {
                        Touching = false;
                        opening = false;
                        closing = true;
                    }
                }
                if (closing)
                {
                    cabinet.transform.Rotate(0, (movement - 2.0f), 0, Space.World);
                    counter = counter - movement;
                    if (counter < 95)
                    {
                        Touching = false;
                        closing = false;
                        opening = true;
                    }
                }

        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Touching = true;
        }
    }

}
