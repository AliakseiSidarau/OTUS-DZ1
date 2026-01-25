using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PlayerModel
{
    [Header("Stats")] 
    public string name = "@JaneWizzard";
    public int level = 99;
    public int xp = 550;
    public int xpMax = 1000;
    
    public float moveSpeed = 10;
    public float intelligence = 55;
    public float stamina = 22;
    public float damage = 35;
    public float regeneration = 15;
    public float dexterity = 18;

    public UnityEvent OnLevelUp = new();
    public UnityEvent<float> OnXpChanged = new();
    public UnityEvent<float> OnStaminaChanged = new();

}
