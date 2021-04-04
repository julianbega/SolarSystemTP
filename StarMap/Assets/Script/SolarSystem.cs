using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public GameObject[] PosiblePlanets;
    public int actualPlanetInSystem;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PosiblePlanets.Length);
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
            Instantiate(PosiblePlanets[selectedPlanets[i]]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
