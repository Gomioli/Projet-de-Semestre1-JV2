using UnityEngine;
using UnityEngine.InputSystem;

public class NodeRoad : MonoBehaviour
{
    
    [SerializeField] private GameObject Intersection;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
        
                
        if (Input.GetMouseButton(0))
        {
            Instantiate(Intersection);
        }
    }
}
