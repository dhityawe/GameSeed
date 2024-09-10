using UnityEngine;
using UnityEngine.EventSystems;

public class MouseClick : MonoBehaviour, IPointerClickHandler
{
    public IncomeBase incomeBase;

    void Start()
    {
        // Find the IncomeBase script in the scene
        incomeBase = FindObjectOfType<IncomeBase>();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // Run TapIncome() when the UI element is clicked
        incomeBase.TapIncome();

        Debug.Log("Mouse Clicked");
    }
}
