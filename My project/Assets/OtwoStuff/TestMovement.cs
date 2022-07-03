using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{

    float startTimer = 0;
    float heldDownTime = 0;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            startTimer = Time.time;
            Debug.Log("W");
        }
        if(Input.GetButtonUp("Jump"))  
        {
            heldDownTime = Time.time - startTimer + 1;
            Debug.Log(heldDownTime);
            rb.AddForce(10 * heldDownTime * rb.transform.forward.x, 5 * heldDownTime, 10 * heldDownTime * rb.transform.forward.z, ForceMode.Impulse);
        }
    }
}
