using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] string sortingLayer;
    [SerializeField] int orderInLayer = 0;
    [SerializeField] Renderer bGRenderer;

    void SetSortingLayer()
    {
        
        bGRenderer.sortingLayerName = sortingLayer;
        bGRenderer.sortingOrder = orderInLayer;
        
    }
}
