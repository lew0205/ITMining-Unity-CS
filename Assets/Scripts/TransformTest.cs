using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{

    float speed = 20.0f;

    float rotSpeed = 5.0f;

    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);

        float MouseX = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up * rotSpeed * MouseX);
    }
}
