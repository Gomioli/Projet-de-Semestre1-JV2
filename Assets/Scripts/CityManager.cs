using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    //[SerializeField] public List<GameObject> cities = new List<GameObject>();
    //[SerializeField] public List<bool> citiesClicked = new List<bool>();
    
    [SerializeField] public List<NodeCity> cities = new List<NodeCity>();
    
    [SerializeField] public List<GameObject> citiesClicked = new List<GameObject>();
    [SerializeField] public List<GameObject> citiesNotClicked = new List<GameObject>();
    
    
    void Start()
    {
        foreach (GameObject city in GameObject.FindGameObjectsWithTag("City"))
        {
            cities.Add(city.GetComponent<NodeCity>());
            citiesNotClicked.Add(city);
        }
    }
    
    void Update()
    {
        foreach (NodeCity city in cities)
        {
            if (city.isCityClicked)
            {
                citiesNotClicked.Remove(city.gameObject);
                citiesClicked.Add(city.gameObject);
            }
        }
    }
    
    
    
}
