using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jumping : MonoBehaviour
{

    public Rigidbody rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 20;
    float jumpTime;
    bool jumping;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            jumpTime = 0;
        }
        if (jumping)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpAmount);
            jumpTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space) | jumpTime > buttonTime)
        {
            jumping = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }

}
