using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick : MonoBehaviour, IPointerClickHandler
{
    public bool isHighlighted;

    [Header("Scriptable Object References")]
    public IncomeBase incomeBase;
    public StatsSO statsSO;
    public PlayerStatsSO playerStatsSO;

    void Start()
    {
        // Find the IncomeBase script in the scene
        incomeBase = FindObjectOfType<IncomeBase>();
        playerStatsSO = FindObjectOfType<PlayerStatsSO>();

        statsSO.StartInitialValues();

        isHighlighted = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Mouse Clicked on the Object");
        
        if (isHighlighted)
        {
    
            Debug.Log("Upgrading cost");
        }
        else
        {
            isHighlighted = true;
            Debug.Log("Button is highlighted");
        }

        isHighlighted = true;
    }
}
