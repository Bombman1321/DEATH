using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{

    private Transform position;
    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            position.Translate(Vector3.forward * 0.02f, Space.World);
        }
        if (Input.GetKey("a"))
        {
            position.Translate(Vector3.left * 0.02f, Space.World);
        }
        if (Input.GetKey("s"))
        {
            position.Translate(Vector3.back * 0.02f, Space.World);
        }
        if (Input.GetKey("d"))
        {
            position.Translate(Vector3.right * 0.02f, Space.World);
        }
    }
}
