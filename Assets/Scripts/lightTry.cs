using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Light myLight = GetComponent<Light>();
        //myLight.intensity = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void linghtOneOn()
    {
        Light myLight = GetComponent<Light>();
        myLight.intensity = 1;
    }
}
