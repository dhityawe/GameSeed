using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public IncomeBase incomeBase; // Reference to your IncomeBase script

    public OnClick onClick; // reference to every object that has the OnClick script

    void Start()
    {
        // Optionally find the IncomeBase script in the scene if not set in the Inspector
        incomeBase = FindObjectOfType<IncomeBase>();
        onClick = FindObjectOfType<OnClick>();
    }

    void Update()
    {
        MouseClickCheck();
    }

    public void MouseClickCheck()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) // 0 is the left mouse button, 1 is the right mouse button
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the raycast hit this object
                if (hit.collider.gameObject == gameObject)
                {
                    // Call TapIncome() on the IncomeBase script
                    if (incomeBase != null)
                    {
                        onClick.isHighlighted = false;
                        incomeBase.TapIncome();
                        Debug.Log("Mouse Clicked on Plane");
                    }
                }
            }
        }
    }
}
