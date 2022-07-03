using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 200.0f);
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 200.0f, 0);
    }
}
