using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    void Start()
    {
        // transform.position = new Vector3(0.0f, 0.5f, 5.0f);

        //transform.Translate(new Vector3(0.0f, 0.5f, -5.0f));
    }

    float speed = 20.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }
}
