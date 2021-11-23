using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class FirstPersonCamera : MonoBehaviour
{
    //The camera attaced to the player
    public Camera playerCamera;

    //Container variables for the mouse delta values each frame
    public float deltaX;
    public float deltaY;

    //Container variables for the player's rotation around the X and Y axis
    public float xRot;
    public float yRot;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;// set player camera
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        yRot += deltaX;
        xRot -= deltaY;

        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //rotate the camera arond the x-axis
        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }

    //OnCameraLook evet handler
    public void OnCameraLook(InputValue value)
    {   
        //Reading the mouse deltas as a vector 2 (delta X is the x componet and deltaY is the y component)
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x * 0.1f;
        deltaY = inputVector.y * 0.1f;

    }
}
