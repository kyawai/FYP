using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkBoardNails : MonoBehaviour
{
    public Texture2D tex1;
    public Texture2D tex2;
    public Texture2D tex3;
    public Texture2D tex4;
    public Texture2D tex5;
    public Texture2D tex6;
    public Texture2D tex7;
    public Texture2D tex8;
    Renderer m_renderer;
    public ChalkBoardStart getStart;
    public AudioSource data;

    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.material.SetTexture("_MainTex", tex1);
    }
    void Update()
    {
        if (getStart.start == true)
        {
            StartCoroutine(ChalkCoroutine());
            data.Play(0);
            getStart.start = false;

        }

    }
    IEnumerator ChalkCoroutine()
    {
        m_renderer.material.SetTexture("_MainTex", tex1);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex2);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex3);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex4);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex5);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex6);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex7);
        yield return new WaitForSeconds(0.5f);
        m_renderer.material.SetTexture("_MainTex", tex8);
        yield return new WaitForSeconds(0.5f);
    }
}
