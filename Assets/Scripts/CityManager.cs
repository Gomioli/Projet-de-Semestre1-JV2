using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> cities = new List<GameObject>();
    
    
    void Start()
    {
        cities.AddRange(GameObject.FindGameObjectsWithTag("City"));
    }
    
    void Update()
    {
        
    }
}
