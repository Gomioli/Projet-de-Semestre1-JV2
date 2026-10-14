using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    //[SerializeField] public List<GameObject> cities = new List<GameObject>();
    //[SerializeField] public List<bool> citiesClicked = new List<bool>();
    
    [SerializeField] public List<NodeCity> cities = new List<NodeCity>();
    
    
    void Start()
    {
        foreach (GameObject city in GameObject.FindGameObjectsWithTag("City"))
        {
            cities.Add(city.GetComponent<NodeCity>());
        }
    }
    
    void Update()
    {
        
    }
}
