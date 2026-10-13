using UnityEngine;
using UnityEngine.InputSystem;

public class NodeRoad : MonoBehaviour
{
    
    [SerializeField] private GameObject Intersection;
    
    private Vector2 interPos;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            interPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log(interPos);
            Instantiate(Intersection, interPos2, Quaternion.identity);
        }
        
        
    }
}
