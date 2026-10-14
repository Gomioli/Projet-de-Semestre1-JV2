using UnityEngine;

public class NodeCity : MonoBehaviour
{
    [SerializeField] private LayerMask cityLayer;

    public bool isCityClicked = false;
    
    void Start()
    {
        isCityClicked = false;
    }


    void Update()
    {

        // Prend la position de la souris
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        
        // Capte lorsque la souris appuie sur un GO dans cityLayer
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D detectedCollider = Physics2D.OverlapPoint(mousePos, cityLayer);
            isCityClicked = detectedCollider == null;
            
            //Je ne sais pas pourquoi il m'affiche le Debug.Log 2 fois
            Debug.Log("CLICKED");
        }

    }
}
