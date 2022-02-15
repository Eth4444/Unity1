using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController charCont;

    private Vector3 moveDirection = Vector3.zero;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        charCont = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        moveDirection = transform.right * moveX + transform.forward * moveZ;
        charCont.Move(moveDirection * speed * Time.deltaTime);
    }
}
