using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Color color = collision.gameObject.GetComponent<Renderer>().material.color;
        collision.gameObject.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, 0.5F);

    }
    private void OnTriggerExit(Collider collision)
    {
        Color color = collision.gameObject.GetComponent<Renderer>().material.color;
        collision.gameObject.GetComponent<Renderer>().material.color = new Color(color.r, color.g, color.b, 1);

    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
