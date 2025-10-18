using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private int _score = 0;
    [SerializeField] private UIDisplayer _iDisplayer;

    public void AddScore()
    {
        _score++;
        _iDisplayer.PrintScore(_score);
    }

    public void Loss()
    {
        _iDisplayer.ActivatePanel();
        _iDisplayer.ShowRecord(_score);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}