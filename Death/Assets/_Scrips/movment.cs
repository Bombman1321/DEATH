using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{

    private Transform position;
    Rigidbody m_Rigidbody;
    float m_Speed;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.GetComponent<Transform>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            m_Rigidbody.velocity = transform.forward *0.5f * m_Speed;
        }
        if (Input.GetKey("a"))
        {
          //  position.Translate(Vector3.left * 0.02f, Space.World);
            transform.Rotate(Vector3.up * 10f * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            position.Translate(Vector3.back * 0.02f, Space.World);
        }
        if (Input.GetKey("d"))
        {
           // position.Translate(Vector3.right * 0.02f, Space.World);
            transform.Rotate(Vector3.up * -10f * Time.deltaTime);
        }
    }
}
