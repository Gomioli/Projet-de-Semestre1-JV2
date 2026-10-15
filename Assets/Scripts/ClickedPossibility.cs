using UnityEngine;

public class ClickedPossibility : MonoBehaviour
{
    
    public bool isPossibilityClicked;
    
    
    void Start()
    {
        isPossibilityClicked = false;
    }
    
    void Update()
    {
        // Prend la position de la souris
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Prend le collider2D du GO du script dans la variable detectedCollider
        Collider2D detectedCollider = GetComponent<Collider2D>();
        
        if(detectedCollider.OverlapPoint(mousePos) && Input.GetMouseButtonDown(0)) // Renvoie un bool de si la position (mousePos) se trouve à l'intérieur d'un collider2D ET Si j'appuie sur ma souris
        {
            isPossibilityClicked = true;
        }
    }
}
