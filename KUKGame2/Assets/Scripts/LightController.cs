using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light1;
    private void OnMouseDown()
    {
        light1.enabled = !light1.enabled;
    }
}