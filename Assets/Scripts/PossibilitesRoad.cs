using System.Collections.Generic;
using UnityEngine;

public class PossibilitesRoad : MonoBehaviour
{

    [SerializeField] private CityManager cityManager;
    
    [SerializeField] private GameObject possibilitesPrefab;

    public List<Transform> possibilities = new List<Transform>();
    
    private int NumberPossibilities = 45;
    private bool possibilitiesInstantiated = false;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (NodeCity city in cityManager.cities)
        {
            if (city.isCityClicked && possibilitiesInstantiated == false)
            {
                Transform cityTransform = city.transform;
                
                GameObject instance = Instantiate(possibilitesPrefab, city.transform.position, city.transform.rotation);
                possibilitiesInstantiated = true;
                
                int NumberPossibility = instance.transform.childCount;

                for (int i = 0; i < NumberPossibility; i++)
                {
                    possibilities.Add(possibilitesPrefab.gameObject.transform.GetChild(i).transform);
                }
                
            }
        }
    }
}
