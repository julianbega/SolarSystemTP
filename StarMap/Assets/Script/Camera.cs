using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public List<Transform> Planetas;

    private int actualPlanetInSight;
    private Vector3 NewCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        actualPlanetInSight = 0;
        NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
        NewCameraPosition.y += 10;
        this.transform.position = NewCameraPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (actualPlanetInSight == 8)
            {
                actualPlanetInSight = 0;
            }
            else
            {
                actualPlanetInSight += 1;
            }
            
            NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
            NewCameraPosition.y += 10;
            this.transform.position = NewCameraPosition;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (actualPlanetInSight == 0)
            {
                actualPlanetInSight = 8;
            }
            else 
            {
                actualPlanetInSight -= 1;
            }
            NewCameraPosition = Planetas[actualPlanetInSight].transform.position;
            NewCameraPosition.y += 10;
            this.transform.position = NewCameraPosition;
            
        }
    }
}
