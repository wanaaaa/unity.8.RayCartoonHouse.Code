using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigCube2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1212121212);
        gameObject.BroadcastMessage("SetFloorSize");
    }

}
