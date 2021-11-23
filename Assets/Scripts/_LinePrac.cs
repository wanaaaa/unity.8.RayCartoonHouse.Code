using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _LinePrac : MonoBehaviour
{
    private LineRenderer lineRen;
    public GameObject endObject;
    
    // Start is called before the first frame update
    void Start()
    {
        //lineRen = gameObject.GetComponent<LineRenderer>();   
        //lineRen.startColor = Color.red;
        //lineRen.endColor = Color.red;

        //lineRen.startWidth = 0.05f;
        //lineRen.endWidth = 0.05f;

        //lineRen.SetPosition(0, new Vector3(-6.054f, 3.68f, 0.16f));
        //Vector3 endVec = endObject.transform.position;
        ////lineRen.SetPosition(1, new Vector3(-6.054f, 3.68f, 4.75f));
        //lineRen.SetPosition(1, endVec);

    }

    // Update is called once per frame
    void Update()
    {
        lineRen = gameObject.GetComponent<LineRenderer>();
        lineRen.startColor = Color.red;
        lineRen.endColor = Color.red;

        lineRen.startWidth = 0.05f;
        lineRen.endWidth = 0.05f;

        lineRen.SetPosition(0, new Vector3(-6.054f, 3.68f, 0.16f));
        Vector3 endVec = endObject.transform.position;
        //lineRen.SetPosition(1, new Vector3(-6.054f, 3.68f, 4.75f));
        lineRen.SetPosition(1, endVec);

    }
}
