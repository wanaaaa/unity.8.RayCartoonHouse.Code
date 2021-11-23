using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //SendMessage("tryFun", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transform root = this.transform;
        while (root.parent != null)
        {
            root = root.parent;
        }
        root.BroadcastMessage("xFunitureFun");
    }

    private void OnTriggerExit(Collider other)
    {
        Transform root = this.transform;
        while (root.parent != null)
        {
            root = root.parent;
        }
        root.BroadcastMessage("xFunitureFunAAA");
    }


}
