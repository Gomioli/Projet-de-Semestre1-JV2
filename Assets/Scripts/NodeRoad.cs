using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NodeRoad : MonoBehaviour
{
    
    [SerializeField] private GameObject Intersection;
    
    [SerializeField] private CityManager cityManager;
    [SerializeField] private PossibilitesRoad possibilitesRoad;
    //[SerializeField] private ClickedPossibility clickPossibility;
    
    private Vector2 interPos;
    private Vector2 possibilityPos;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (NodeCity city in cityManager.cities)
            {
                if (city.isCityClicked)
                {
                    CheckWhichPossibility();
                    InstantiateIntersection(possibilityPos);
                }
            }
        }
    }

    public void InstantiateIntersection(Vector2 futurPos)
    {
        // // Prend la position de la souris   
        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     
        // // Prend les vecteurs x et y, et modifie le vecteur z pour qu'il soit au dessus du terrain vert
        // Vector3 spawnPos = new Vector3(mousePos.x, mousePos.y, -9);
            
        Instantiate(Intersection, futurPos, Quaternion.identity);
    }


    public void CheckWhichPossibility()
    {
        foreach (ClickedPossibility possibility in possibilitesRoad.possibilities)
        {
            if (possibility.isPossibilityClicked)
            {
                possibilityPos = possibility.transform.position;
                Debug.Log(possibility.transform.position);
            }
        }
    }
    
    
}
