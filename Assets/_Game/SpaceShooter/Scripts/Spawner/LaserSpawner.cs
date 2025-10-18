using System.Collections;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _delay = 0.3f;
    [SerializeField] private Transform _spawnPosotion;

    private void Start()
    {
        StartCoroutine(DelaySpawn());
    }

    private IEnumerator DelaySpawn()
    {
        while (true)
        {
            Instantiate(_prefab, _spawnPosotion.position, Quaternion.identity);
            yield return new WaitForSeconds(_delay);
        }
    }
}