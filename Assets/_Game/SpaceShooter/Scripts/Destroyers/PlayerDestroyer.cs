using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _defeatMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Asteroid asteroid))
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            Destroy(asteroid.gameObject);
            _defeatMenu.SetActive(true);
            //Time.timeScale = 0;
            // Destroy(gameObject);
            Invoke("Test", 0.8f);
        }
    }

    private void Test()
    {
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}