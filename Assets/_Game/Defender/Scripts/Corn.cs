using UnityEngine;

public class Corn : MonoBehaviour
{
    [field: SerializeField] public int StartHealth { get; private set; } = 10;
    [field: SerializeField] public int HealthPerUpgrade { get; private set; } = 2;

    public int Health { get; private set; }
    public int Crystals { get; private set; }

    private void Awake()
    {
        LoadGameData();
    }

    private void LoadGameData()
    {
        int healthGrade = PlayerPrefs.GetInt(Constants.HealthGrade, 0);
        Health = StartHealth + HealthPerUpgrade * healthGrade;
        Crystals = PlayerPrefs.GetInt(Constants.Crystals, 0);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void AddCrystals(int crystals)
    {
        Crystals += crystals;
        SaveController.SaveCrystals(Crystals);
    }

    public bool TrySpendCrystals(int crystals)
    {
        if (Crystals < crystals) return false;

        Crystals -= crystals;

        SaveController.SaveCrystals(Crystals);
        return true;
    }

    public void RecalculateHealth()
    {
        int healthGrade = PlayerPrefs.GetInt(Constants.HealthGrade, 0);
        Health = StartHealth + HealthPerUpgrade * healthGrade;
    }
}