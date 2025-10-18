using System.Collections;
using UnityEngine;

public class InteractSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _delay = 0.3f;
    [SerializeField] private Transform _leftBorder;
    [SerializeField] private Transform _rightBorder;

    private void Start()
    {
        StartCoroutine(DelaySpawn());
    }

    private IEnumerator DelaySpawn()
    {
        while (true)
        {
            float randomX = Random.Range(_leftBorder.position.x, _rightBorder.position.x);
            Vector2 newPosition = transform.position;
            newPosition.x = randomX;

            Instantiate(_prefab, newPosition, Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}