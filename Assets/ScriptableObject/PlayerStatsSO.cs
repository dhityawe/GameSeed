using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatsSO", menuName = "ScriptableObjects/PlayerStatsSO", order = 1)]
public class PlayerStatsSO : ScriptableObject
{
    [Header("Initial Player Stats")]
    public float initialMoney; // Holds the initial money
    public float initialPassiveIncomePerSecond;
    public float initialTapIncome;

    [Header("Player Money")]
    public float currentMoney; // Holds the current money

    [Header("Player Passive Income")]
    public float currentPassiveIncomePerSecond;
    public float currentPassiveIncomePerSecondMultiplier;   

    [Header("Player Tap Income")]
    public float currentTapIncome; // Holds the current tap income
    public float currentTapIncomeMultiplier;
    public GameObject tapIncomePrefabText; // Reference to the tap income prefab

    public void StartInitialValues()
    {
        currentMoney = initialMoney;
        currentPassiveIncomePerSecond = initialPassiveIncomePerSecond;
        currentTapIncome = initialTapIncome;

        currentPassiveIncomePerSecondMultiplier = 0;
        currentTapIncomeMultiplier = 0;
    }
}
