using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject player;
    public CharacterController controller;
    public float speed = 10f;;
    void Start()
    {
        
    }

    void Update()
    {
        float x_axis = Input.GetAxis("Horizontal");
        float z_axis = Input.GetAxis("Vertical");
        Vector3 move=transform.right*x_axis+transform.forward*z_axis;
        controller.Move(move*speed*Time.deltaTime);
    }
}
