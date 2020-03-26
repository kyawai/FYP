using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBookPick : MonoBehaviour
{
    public Texture2D tex1;
    public Texture2D tex2;
    Renderer m_renderer;
    public NoteBook getPick;
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.material.SetTexture("_MainTex", tex1);
    }
    void Update()
    {
        if (getPick.pick == true)
        {
            m_renderer.material.SetTexture("_MainTex", tex2);
        }
        if (getPick.pick == false)
        {
            m_renderer.material.SetTexture("_MainTex", tex1);
        }

    }
}
