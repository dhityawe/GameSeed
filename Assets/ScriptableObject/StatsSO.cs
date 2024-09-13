using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatsSO", menuName = "ScriptableObjects/StatsSO", order = 2)]
public class StatsSO : ScriptableObject
{
    [Header("Background Reference")]
    public Material bgBorderNotEnoughMoney;
    public Material bgBorderEnoughMoney;
    public Material bgBorderIsHighlighted;
    public Material backgroundModel;

    [Header("Evolution Reference 2D")]
    public Sprite model2D;

    [Header("Life Model Display Reference 3D")]
    public Mesh model3D;
    public Material material3D;

    [Header("Category")]
    public CategoryType categoryType;
    public EvolutionEffect evolutionEffect;

    [Header("Stats Description")]
    public new string name;
    public string effectDescription;
    public string description;


    [Header("Initial Stats")]
    public float initialCost;
    public float initialEffect;
    public float initialLevel;

    [Header("Stats")]
    public float cost;
    public float effect;
    public float upgradeLevel;
    public float upgradeLimit;

    public void StartInitialValues()
    {
        cost = initialCost;
        effect = initialEffect;
        upgradeLevel = initialLevel;
    }

}

// Move the enums outside of the class so Unity can serialize them
public enum CategoryType
{
    Life,
    Evolution
}

public enum EvolutionEffect
{
    Tap,
    Passive,
    Effective
}


