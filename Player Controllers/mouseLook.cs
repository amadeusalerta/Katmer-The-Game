using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float mouse_sensivity = 350f;
    public Transform player_body;
    public float xRotation=0;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*mouse_sensivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouse_sensivity*Time.deltaTime;
        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation= Quaternion.Euler(xRotation,0f,0f);
        player_body.Rotate(Vector3.up * mouseX);
    }
}
