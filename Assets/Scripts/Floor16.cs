using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor16 : MonoBehaviour
{
    void Start()
    {
        //Light myLight = GetComponent<Light>();
        //myLight.intensity = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetFloorSize()
    {

        transform.localScale = new Vector3(0.66666666f, 3.3333333f, 1f);
    }
}
