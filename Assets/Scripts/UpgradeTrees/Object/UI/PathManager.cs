using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public List<PathNode> pathNodes;

    void Update()
    {
        // Handle path updates if needed
    }

    public void OnPathNodeClicked(PathNode clickedNode)
    {
        clickedNode.OnNodeClick(); // Trigger the click behavior for each node
    }
}
