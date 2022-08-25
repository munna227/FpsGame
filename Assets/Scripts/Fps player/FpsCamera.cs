using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FpsCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    float xRotation;
    bool isCursor=false;

   

    // Update is called once per frame
    void Update()
    {
        CursorLock();

        float mouseX = Input.GetAxis("Mouse X");
         float mouseY = Input.GetAxis("Mouse Y");
    
       
        mouseX *= mouseSensitivity;
        mouseY *= mouseSensitivity;

        xRotation -= mouseY * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        playerBody.Rotate(Vector3.up * mouseX * Time.deltaTime);
    }
    void CursorLock()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            isCursor = true;

        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            isCursor = false;
        }
        if (isCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }
}