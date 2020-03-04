using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLogic : MonoBehaviour
{
    new Rigidbody rigidbody = new Rigidbody();

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector3(0, 300, 0));
        }
    }
}
