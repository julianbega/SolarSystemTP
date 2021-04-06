using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float timeToDelete;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToDelete -= Time.deltaTime;
        if (timeToDelete <= 0) Destroy(this.gameObject);

        this.gameObject.transform.position -= new Vector3(1.0f, 0.0f, 1.0f) *speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
       Destroy(this.gameObject);
    }
}
