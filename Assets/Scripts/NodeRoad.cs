using UnityEngine;
using UnityEngine.InputSystem;

public class NodeRoad : MonoBehaviour
{
    
    [SerializeField] private GameObject Intersection;
    
    private Vector2 interPos;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            interPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
            Instantiate(Intersection, interPos, Quaternion.identity);
        }
    }
}
