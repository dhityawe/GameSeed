using UnityEngine;

public class OnClick : MonoBehaviour
{
    public bool isHighlighted;
    public bool isMoneyEnough;

    public GameObject upgradePopUp;
    public GameObject bgBorder;

    [Header("Scriptable Object References")]
    public IncomeBase incomeBase;
    public StatsSO statsSO;
    public PlayerStatsSO playerStatsSO;

    void Start()
    {
        incomeBase = FindObjectOfType<IncomeBase>();

        statsSO.StartInitialValues();

        isHighlighted = false;
    }

    void Update()
    {
        MoneyCheck();
        BgBorderUpdate();

        if (statsSO.upgradeLimit >= statsSO.upgradeLevel)
        {
            OnPointerClick();
        }
        else
        {
            Destroy(upgradePopUp);
            Debug.Log ("Upgrade limit reached");
        }

        if (!isHighlighted)
        {
            upgradePopUp.SetActive(false);
        }
    }

    public void BgBorderUpdate()
    {
        if (isHighlighted)
        {
            // Set background material to indicate the button is highlighted
            bgBorder.GetComponent<Renderer>().material = statsSO.bgBorderIsHighlighted;
            Debug.Log("Button is highlighted.");
        }
        else if (isMoneyEnough)
        {
            // Set background material to indicate the player has enough money
            bgBorder.GetComponent<Renderer>().material = statsSO.bgBorderEnoughMoney;
            Debug.Log("Player has enough money.");
        }
        else
        {
            // Set background material to indicate the player doesn't have enough money
            bgBorder.GetComponent<Renderer>().material = statsSO.bgBorderNotEnoughMoney;
            Debug.Log("Player doesn't have enough money.");
        }
    }


    public void MoneyCheck()
    {
        if (playerStatsSO.currentMoney >= statsSO.cost)
        {
            isMoneyEnough = true;
        }
        else
        {
            isMoneyEnough = false;
        }
    }

    public void OnPointerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    if (isHighlighted)
                    {
                        OnClickUpgradeBehaviour();
                       Debug.Log("Upgrading cost");
                    }
                    else
                    {
                        isHighlighted = true;
                        upgradePopUp.SetActive(true);
                        Debug.Log("Button is highlighted");
                    }
                }
            }
        }
    }

    public void OnClickUpgradeBehaviour()
{
    // Deduct money when upgrading
    playerStatsSO.currentMoney -= statsSO.cost;

    statsSO.cost += statsSO.cost;
    statsSO.effect += statsSO.effect;
    statsSO.upgradeLevel++;

    // Check for the category type
    if (statsSO.categoryType == CategoryType.Life)
    {
        playerStatsSO.currentTapIncome += statsSO.effect;
    }

    else if (statsSO.categoryType == CategoryType.Evolution)
    {
        // Check for evolution effect
        if (statsSO.evolutionEffect == EvolutionEffect.Tap)
        {
            playerStatsSO.currentTapIncome += statsSO.effect;
        }
        else if (statsSO.evolutionEffect == EvolutionEffect.Passive)
        {
            playerStatsSO.currentPassiveIncomePerSecond += statsSO.effect;
        }
        else if (statsSO.evolutionEffect == EvolutionEffect.Effective)
        {
            playerStatsSO.currentTapIncome += statsSO.effect;
            playerStatsSO.currentPassiveIncomePerSecond *= statsSO.effect;
        }
    }
}

}
