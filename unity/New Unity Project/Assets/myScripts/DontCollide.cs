using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontCollide : MonoBehaviour
{
    public GameObject drawer1;
    public GameObject back;
    void Start()
    {
        Physics.IgnoreCollision(drawer1.GetComponent<Collider>(), GetComponent<Collider>());
        Physics.IgnoreCollision(back.GetComponent<Collider>(), GetComponent<Collider>());
    }

}
