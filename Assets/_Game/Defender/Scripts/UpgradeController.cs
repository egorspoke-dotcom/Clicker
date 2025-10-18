using UnityEngine;
using UnityEngine.UI;

public class UpgradeController : MonoBehaviour
{
    [SerializeField] private int _healthGradePrice = 2;
    [SerializeField] private Corn _corn;
    [SerializeField] private Text _healthGradePriceText;

    private int _healthGrade;

    private void Awake()
    {
        _healthGrade = PlayerPrefs.GetInt(Constants.HealthGrade, 0);
    }

    private void Update()
    {
        _healthGradePriceText.text = _healthGradePrice.ToString();
    }

    public void OnClickUpgradeHealth()
    {
        if (_corn.TrySpendCrystals(_healthGradePrice))
        {
            _healthGrade++;
            PlayerPrefs.SetInt(Constants.HealthGrade, _healthGrade);
            PlayerPrefs.Save();
            _corn.RecalculateHealth();
        }
    }
}