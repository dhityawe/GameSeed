using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro cost;

    // Reference script
    private OnClick onClick;

    // Start is called before the first frame update
    void Start()
    {
        // Get OnClick component from the same GameObject
        onClick = GetComponent<OnClick>();

        // Get the statsSO from OnClick script
        if (onClick != null)
        {
            Initialize(onClick.statsSO);
        }
        else
        {
            Debug.LogError("OnClick script not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize(StatsSO statsSO)
    {
        if (statsSO != null)
        {
            title.text = statsSO.name;
            cost.text = statsSO.cost.ToString();
        }
        else
        {
            Debug.LogError("StatsSO is null!");
        }
    }
}
