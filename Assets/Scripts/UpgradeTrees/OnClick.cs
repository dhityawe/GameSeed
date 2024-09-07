using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public bool isHighlighted;

    public StatsSO statsSO;

    void Start()
    {
        isHighlighted = false;
    }

    public void OnClickButton()
    {
        if (isHighlighted)
        {
            statsSO.CostUpgrade();
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
