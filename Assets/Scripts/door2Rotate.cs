using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2Rotate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        transform.eulerAngles = new Vector3(0, -60, 0);
    }
    private void OnTriggerExit(Collider other)
    {
    }

}
