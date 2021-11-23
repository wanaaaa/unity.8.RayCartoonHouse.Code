using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xFurnture : MonoBehaviour
{
    void xFunitureFun()
    {
        Debug.Log("eeeeeeeeeeeeeeeeeee");
        transform.localScale = new Vector3(0f, 0f, 0f);


    }

    void xFunitureFunAAA()
    {
        gameObject.active = true;
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
