using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SphereTMController : MonoBehaviour
{
    public Transform sphere;

    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x += speed * Time.deltaTime;
        }

        Vector3 origin = sphere.transform.position;

        sphere.transform.position = origin + move;
    }
}
