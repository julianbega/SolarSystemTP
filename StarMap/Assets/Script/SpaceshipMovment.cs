using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovment : MonoBehaviour
{
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += new Vector3(0.0f, 0.0f, 1.0f) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += new Vector3(0.0f, 0.0f, -1.0f) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
        }
    }
}
