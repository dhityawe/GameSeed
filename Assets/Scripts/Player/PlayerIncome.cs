using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIncome : MonoBehaviour
{
    public StatsSO statsSO;

    [Header("Player Passive Income")]
    public float currentPassiveIncomePerSecond;
    public float passiveIncomePerSecond;
    public float passiveIncomePerSecondMultiplier;

    [Header("Player Tap Income")]
    public float currentTapIncome;
    public float tapIncome;
    public float tapIncomeMultiplier;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
