using UnityEngine;

public class LineRendererManager : MonoBehaviour
{
    
     [SerializeField] private GameObject LineRendererPrefab;

     [SerializeField] private NodeRoad nodeRoad;
     
     private LineRenderer lineRoad;
     private int index = 0;
    
    
    void Start()
    {
        lineRoad = Instantiate(LineRendererPrefab).GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CreateRoad();
    }


    public void CreateRoad()
    {
        if (nodeRoad.roadReady)
        {
            lineRoad.positionCount = nodeRoad.intersections.Count;
            index = 0;
            foreach (GameObject intersection in nodeRoad.intersections)
            {
                lineRoad.SetPosition(index, intersection.transform.position);
                index++;
            }
        }
    }
}
