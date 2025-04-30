using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphiaScript_szk : MonoBehaviour
{
    public float jumpForce = 5f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
        rb.velocity = new Vector3(rb.velocity.x, 0f,rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
       } 
    }
}
