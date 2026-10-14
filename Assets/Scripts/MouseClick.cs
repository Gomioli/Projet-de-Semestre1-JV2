using UnityEngine;

public class MouseClick : MonoBehaviour
{
    
    [SerializeField] private LayerMask selectableLayer;
    [SerializeField] private NodeCity nodeCity;

    private bool detectedClick = false;
    
    
    void Start()
    {
        detectedClick = false;
    }


    void Update()
    {
        
        // Prend la position de la souris par rapport à l'écran de la caméra
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        
        // Capte lorsque la souris appuie sur un GO dans cityLayer
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D detectedCollider = Physics2D.OverlapPoint(mousePos, selectableLayer);
            if (detectedCollider == null)
            {
                nodeCity.isCityClicked = true;
                detectedClick = true;
            }
            
            //Je ne sais pas pourquoi il m'affiche le Debug.Log 2 fois
            Debug.Log("CLICKED");
        }
    }
}
