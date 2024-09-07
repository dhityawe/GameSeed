using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatsSO", menuName = "ScriptableObjects/PlayerStatsSO", order = 1)]
public class PlayerStatsSO : ScriptableObject
{
    public float passiveIncome;
    public float tapIncome;
}
