﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{

    public GameObject MainCam;

    public int actualPlanetInSystem;
    private int actualPlanetSelected = 8;
    public GameObject[] PosiblePlanets;
    public List<GameObject> ActivePlanets;
    public GameObject Meteors;
    private bool lightIntencifying = true;
    Light mylight;
    public GameObject Spaceship;
    public float timeToNewMeteors;
    public float timeToMeteors;
    // Start is called before the first frame update
    void Start()
    {

        mylight = this.GetComponent<Light>();
        List<int> selectedPlanets = new List<int>();
        int random = 0;
        

        for (int i = 0; i < actualPlanetInSystem; i++)
        {
            do
            {
                random = Random.Range(0, PosiblePlanets.Length);
            } while (selectedPlanets.Contains(random));
            selectedPlanets.Add(random);
            
        }
        for (int i = 0; i < actualPlanetInSystem; i++)
        {
            GameObject go = Instantiate(PosiblePlanets[selectedPlanets[i]]);
            ActivePlanets.Add(go);
        }
        MainCam.transform.position = new Vector3(0.0f, 15.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToMeteors <= 0)
        {
            timeToMeteors = timeToNewMeteors;
            
            GameObject meteor = Instantiate(Meteors);
            meteor.transform.position = new Vector3(36.0f, 0.0f, 36.0f);
        }
        timeToMeteors = timeToMeteors - Time.deltaTime;
        if (mylight.intensity <= 1)
        {
            lightIntencifying = true;
        }
        if (mylight.intensity >= 6)
        {
            lightIntencifying = false;
        }
        if (lightIntencifying)
        {
            mylight.intensity += 1 * Time.deltaTime;
        }
        else 
        {
            mylight.intensity -= 1 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && actualPlanetInSystem >= 1)
        {
            actualPlanetSelected = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && actualPlanetInSystem >= 2)
        {
            actualPlanetSelected = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && actualPlanetInSystem >= 3)
        {
            actualPlanetSelected = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && actualPlanetInSystem >= 4)
        {
            actualPlanetSelected = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && actualPlanetInSystem >= 5)
        {
            actualPlanetSelected = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && actualPlanetInSystem >= 6)
        {
            actualPlanetSelected = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) && actualPlanetInSystem >= 7)
        {
            actualPlanetSelected = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) && actualPlanetInSystem >= 8)
        {
            actualPlanetSelected = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            actualPlanetSelected = 8;            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            actualPlanetSelected = 9;
        }

        if (actualPlanetSelected == 9)
        {
            MainCam.transform.position = Spaceship.transform.position + new Vector3(-1.0f, 8.0f, -4.2f);
        }
        else if (actualPlanetSelected == 8)
        {
            MainCam.transform.position = new Vector3(0.0f, 15.0f, 0.0f);
        }
        else 
        {
            MainCam.transform.position = ActivePlanets[actualPlanetSelected].transform.position + new Vector3(0.0f, 10.0f);
        }
       
          
        

        //cam.transform.position = this.transform.position;
    }
}
