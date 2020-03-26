using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFlashlight : MonoBehaviour
{
    private bool pick = false;
    public GameObject flash;
    public Light lt;
    void Start()
    {
        lt.enabled = false;
    }
    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        RaycastHit zCoord = new RaycastHit();
        if(!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition).origin,
                                 Camera.main.ScreenPointToRay(Input.mousePosition).direction, out zCoord, 1,
                                 Physics.DefaultRaycastLayers))
        {
            return;
        }
        Destroy(flash);
        lt.enabled = true;
        Vector3 mousePoint = Input.mousePosition;
    }


}
