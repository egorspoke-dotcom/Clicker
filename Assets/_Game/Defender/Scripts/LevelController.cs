using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Corn _corn;
    [SerializeField] private GameObject _victoryPanel;
    [SerializeField] private GameObject _defeatPanel;

    public static bool IsFinished { get; private set; } = false;
    public static int Level { get; private set; }

    private void Start()
    {
        Level = PlayerPrefs.GetInt(Constants.Level, 1);
        IsFinished = false;
    }

    private void Update()
    {
        if (IsFinished) return;

        CheckGameState();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        _spawner.Init(Level);
        _victoryPanel.SetActive(false);
        IsFinished = false;
    }

    private void CheckGameState()
    {
        if (_spawner.SpawnCounter <= 0 && Enemy.ActiveEnemies.Count == 0)
        {
            Victory();
        }

        if (_corn.Health <= 0)
        {
            Defeat();
        }
    }

    private void Defeat()
    {
        IsFinished = true;
        _defeatPanel.SetActive(true);
    }

    private void Victory()
    {
        IsFinished = true;
        Level++;
        _victoryPanel.SetActive(true);
        SaveController.SaveLevel(Level);
    }
}