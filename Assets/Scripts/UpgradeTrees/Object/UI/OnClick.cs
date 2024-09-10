using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
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

    public void OnClickButton()
    {
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
