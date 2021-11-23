using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    public Transform cameraTran;
    public GameObject focusedObject;
    LineRenderer lineRen;

    // Update is called once per frame
    void FixedUpdate()
    {   
        //Compute the player's foward direction
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray = new Ray(transform.position, fwd);


        if (Physics.Raycast(ray, out hit))
        {
            lineRen = gameObject.GetComponent<LineRenderer>();
            lineRen.startColor = Color.red;
            lineRen.endColor = Color.red;

            lineRen.startWidth = 0.05f;
            lineRen.endWidth = 0.05f;

            //lineRen.SetPosition(0, transform.position);
            lineRen.SetPosition(0, cameraTran.transform.position);
            Vector3 endPosition = hit.point;
            lineRen.SetPosition(1, endPosition);


            focusedObject = hit.collider.gameObject;
            if (focusedObject.CompareTag("disappear"))
            {
                //Debug.Log(555555555555555);
                focusedObject.SetActive(false);
            }

            if (focusedObject.CompareTag("fan"))
            {
                focusedObject.transform.Rotate(Vector3.up * Time.deltaTime * 60, Space.World);
                //transform.Rotate(Vector3.up * Time.deltaTime * 60, Space.World);
            }
            
        } else
        {
            focusedObject = null;
        }

    }

}
