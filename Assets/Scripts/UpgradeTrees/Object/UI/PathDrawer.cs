using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class PathDrawer : MonoBehaviour
{
    public Transform startNode;
    public Transform endNode;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2; // Start and End points
    }

    void Update()
    {
        // Update line position dynamically
        lineRenderer.SetPosition(0, startNode.position);
        lineRenderer.SetPosition(1, endNode.position);
    }
}
