using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StatsSO", menuName = "ScriptableObjects/StatsSO", order = 2)]
public class StatsSO : ScriptableObject
{
    [Header("Asset Reference 2D")]
    public Sprite model2D;

    [Header("Asset Reference 3D")]
    public Mesh model3D;
    public Material material3D;

    [Header("Category")]
    public CategoryType categoryType;
    public EvolutionEffect evolutionEffect;

    [Header("Stats Description")]
    public new string name;
    public string effectDescription;
    public string description;

    [Header("Stats")]
    public float cost;
    public float effect;

    public void CostUpgrade()
    {
        cost *= 2;  // Double the cost
    }

    public void EffectUpgrade()
    {
        effect *= 2;  // Double the effect
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


