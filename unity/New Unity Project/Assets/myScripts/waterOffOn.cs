using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterOffOn : MonoBehaviour
{
    public GameObject water;
    // Start is called before the first frame update
    void Start()
    {
        water.SetActive(false);
    }
    void Update()
    {
        water.SetActive(true);
    }
}
