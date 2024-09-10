using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncomeBase : MonoBehaviour
{
    [Header("Component References")]
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI passiveIncomeText;

    [Header("Scriptable Object References")]
    public PlayerStatsSO playerStatsSO;

    void Start()
    {
        playerStatsSO.StartInitialValues();
    }

    void Update()
    {
        UpdateIncomeData();
        PassiveIncome();
    }

    public void UpdateIncomeData()
    {
        // Update the player's money text display
        moneyText.text = playerStatsSO.currentMoney.ToString("F0");

        // Update the passive income text display
        passiveIncomeText.text = playerStatsSO.currentPassiveIncomePerSecond.ToString("F0") + " /s";

        // Update the tap income text display
        playerStatsSO.tapIncomePrefabText.GetComponent<TextMeshProUGUI>().text = playerStatsSO.currentTapIncome.ToString("F0");
    }

    public void TapIncome()
    {
        // Increase the player's money by the tap income amount
        playerStatsSO.currentMoney += playerStatsSO.currentTapIncome;
        moneyText.text = playerStatsSO.currentMoney.ToString("F0");
    }

    public void PassiveIncome()
    {
        // Increase the player's money by the passive income amount
        playerStatsSO.currentMoney += playerStatsSO.currentPassiveIncomePerSecond * Time.deltaTime;
        moneyText.text = playerStatsSO.currentMoney.ToString("F0");
    }


}
