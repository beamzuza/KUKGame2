using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public DoorController door;
    public bool playStay = false;
    public GameObject canvas;

    private void Update()
    {
        canvas.SetActive(playStay);
        if(playStay && Input.GetKeyDown(KeyCode.E))
        {
            door.doorOpen = !door.doorOpen;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playStay = true;
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playStay = false;
        }
        
    }
}
