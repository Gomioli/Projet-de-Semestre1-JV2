using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NodeRoad : MonoBehaviour
{
    [SerializeField] public List<GameObject> intersections = new List<GameObject>();
    
    [SerializeField] private GameObject Intersection;
    [SerializeField] private GameObject RayonPossibility;
    
    [SerializeField] private CityManager cityManager;
    [SerializeField] private PossibilitesRoad possibilitesRoad;
    
    private Vector2 interPos;
    private Vector2 possibilityPos;

    private GameObject rayonActuel;
    private Collider2D rayonActuelCollider;
    
    public bool roadReady = false;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (rayonActuel == null)
            {
                foreach (NodeCity city in cityManager.cities)
                {
                    if (city.isCityClicked)
                    {
                        InvokePossibility(city.transform);
                    }
                }
            }
            else if (rayonActuelCollider.OverlapPoint(mousePos))
            {
                if (cityManager.citiesClicked.Count != 2)
                {
                    InstantiateIntersection();
                }
                StopRoad();

            }
            
        }
    }

    public void InstantiateIntersection()
    {
        // Prend la position de la souris   
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        // Prend les vecteurs x et y, et modifie le vecteur z pour qu'il soit au dessus du terrain vert
        Vector3 spawnPos = new Vector3(mousePos.x, mousePos.y, -9);
        
        
        GameObject interInstance = Instantiate(Intersection, spawnPos, Quaternion.identity);
        intersections.Add(interInstance);
        if (rayonActuel != null)
        {
            rayonActuel.transform.position = spawnPos;
        }
    }

    
    
    
    
    public void InvokePossibility(Transform cityTransform)
    {
        rayonActuel =  Instantiate(RayonPossibility, cityTransform.position, Quaternion.identity);
        rayonActuelCollider = rayonActuel.GetComponent<Collider2D>();
    }


    public void StopRoad()
    {
        if (rayonActuel != null)
        {
            if (cityManager.citiesClicked.Count == 2)
            {
                Destroy(rayonActuel);
                roadReady = true;
            }
            
        }
    }
    
    
    
}
