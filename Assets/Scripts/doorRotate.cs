using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorRotate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.eulerAngles = new Vector3(0, 110, 0);
    }

    private void OnTriggerExit(Collider other)
    {

    }

}
