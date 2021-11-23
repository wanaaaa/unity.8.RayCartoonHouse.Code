using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanFloor : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("floor@@@@@@@@@@@@@@");
        gameObject.BroadcastMessage("linghtOneOn");


    }

    private void OnTriggerExit(Collider other)
    {

    }

}
