using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Asteroid asteroid))
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            Destroy(asteroid.gameObject);
            Destroy(gameObject);
        }
    }
}