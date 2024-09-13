using System.Collections.Generic;
using UnityEngine;

public class PathNode : MonoBehaviour
{
    public StatsSO statsSO;
    public PathNode[] prerequisiteNodes; // Nodes that need to be unlocked before this one
    public bool isUnlocked;
    public GameObject upgradePopUp;  // The upgrade popup shown when the player clicks on the node
    
    private PlayerStatsSO playerStatsSO;
    private Renderer nodeRenderer;

    void Start()
    {
        playerStatsSO = FindObjectOfType<PlayerStatsSO>();
        nodeRenderer = GetComponent<Renderer>();
        statsSO.StartInitialValues();
        UpdateNodeVisual();
    }

    void Update()
    {
        // Check if all prerequisites are unlocked
        if (ArePrerequisitesUnlocked() && playerStatsSO.currentMoney >= statsSO.cost && !isUnlocked)
        {
            nodeRenderer.material = statsSO.bgBorderEnoughMoney;
        }
        else if (!isUnlocked)
        {
            nodeRenderer.material = statsSO.bgBorderNotEnoughMoney;
        }
    }

    bool ArePrerequisitesUnlocked()
    {
        foreach (PathNode node in prerequisiteNodes)
        {
            if (!node.isUnlocked)
                return false;
        }
        return true;
    }

    public void OnNodeClick()
    {
        if (isUnlocked)
        {
            Debug.Log("Node already unlocked");
            return;
        }

        if (ArePrerequisitesUnlocked() && playerStatsSO.currentMoney >= statsSO.cost)
        {
            UnlockNode();
        }
    }

    void UnlockNode()
    {
        isUnlocked = true;
        playerStatsSO.currentMoney -= statsSO.cost;
        nodeRenderer.material = statsSO.bgBorderIsHighlighted;  // Change the visual state to "highlighted" when unlocked
        statsSO.upgradeLevel++;  // Perform any upgrade logic here
        upgradePopUp.SetActive(true);
        Debug.Log("Node unlocked: " + statsSO.name);
    }

    void UpdateNodeVisual()
    {
        if (isUnlocked)
        {
            nodeRenderer.material = statsSO.bgBorderIsHighlighted;
        }
        else
        {
            nodeRenderer.material = statsSO.bgBorderNotEnoughMoney;
        }
    }
}
