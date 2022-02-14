using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController charCont;

    private Vector3 moveDirection = Vector3.zero; //initialzing variable(moveDirection) as movement factor (vector3)
    public float speed = 10f; // 'speed' is a public variable that can be ajusted in unity editor

    // Start is called before the first frame update
    private void Start()
    {
        charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); //storing user input to variable
        float moveZ = Input.GetAxis("Vertical");   // storing user input to variable

        moveDirection = transform.right * moveX + transform.forward * moveZ; // consolidating movement factors under one variable
        charCont.Move(moveDirection * speed * Time.deltaTime);
    }
}
