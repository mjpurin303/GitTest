using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_uController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Application.targetFrameRate = 60; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.01f,0.01f,0));
        
    }
}
