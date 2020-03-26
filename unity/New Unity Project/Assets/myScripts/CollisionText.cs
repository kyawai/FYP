using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionText : MonoBehaviour
{
    private bool show = false;
    public GameObject detection;
    public Text open;
    void Update()
    {
        if (show)
        {
            open.enabled = true;
        }
        if (!show)
        {
            open.enabled = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            show = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            show = false;
        }
    }
}
