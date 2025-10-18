using TMPro;
using UnityEngine;

public class UIDisplayer : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private TextMeshProUGUI _record;
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void ActivatePanel()
    {
        _losePanel.SetActive(true);
    }

    public void ShowRecord(int score)
    {
        _record.text = score.ToString();
    }

    public void PrintScore(int score)
    {
        _scoreText.text = score.ToString();
    }
}