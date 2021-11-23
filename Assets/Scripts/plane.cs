using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(99999999999);
        gameObject.BroadcastMessage("Floor15");
    }

    private void OnTriggerExit(Collider other)
    {

    }


}
