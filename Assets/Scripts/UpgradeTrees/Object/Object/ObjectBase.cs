using System.Collections;
using TMPro;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro cost;

    // Reference to OnClick
    private OnClick onClick;
    private PlayerStatsSO playerStatsSO;

    // Start is called before the first frame update
    void Start()
    {
        // Get OnClick component from the same GameObject
        onClick = GetComponent<OnClick>();

        // Get the PlayerStatsSO from the scene
        playerStatsSO = FindObjectOfType<PlayerStatsSO>();

        // Use StatsSO from OnClick instead of GetComponent
        if (onClick != null && onClick.statsSO != null)
        {
            Initialize(onClick.statsSO); // Pass StatsSO from OnClick to Initialize
        }
        else
        {
            Debug.LogError("OnClick script or StatsSO is missing!");
        }
    }

    void Update()
    {
        UpdateCurrentData();
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

    public void UpdateCurrentData()
    {
        cost.text = onClick.statsSO.cost.ToString();
    }
}
