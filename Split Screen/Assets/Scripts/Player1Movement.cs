using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed * 2f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed / 2f;
        }        
    }
}
