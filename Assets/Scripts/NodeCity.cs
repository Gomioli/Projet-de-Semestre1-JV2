using UnityEngine;

public class NodeCity : MonoBehaviour
{
    [SerializeField] private LayerMask cityLayer;

    public bool isCityClicked = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Collider2D detectedCollider = Physics2D.OverlapPoint(mousePos, cityLayer);

        if (detectedCollider == null)
        {
            isCityClicked = false;
        }
    }
}
