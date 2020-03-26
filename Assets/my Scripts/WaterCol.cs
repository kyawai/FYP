using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCol : MonoBehaviour
{
    public Water col;
    Renderer m_renderer;

    private void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.material.SetColor("_horizonColor", Color.clear);
    }
    private void Update()
    {
        if(col.colour == true)
        {
            m_renderer.material.SetColor("_horizonColor", Color.red);
        }
        if(col.colour == false)
        {
            m_renderer.material.SetColor("_horizonColor", Color.clear);
        }
    }
}
