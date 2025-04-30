using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubuCOntroller : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.Rotate(40f,1f,0);
        rb.transform.Translate(-3,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
