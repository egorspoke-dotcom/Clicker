using UnityEngine;

public class DelayDestroyer : MonoBehaviour
{
    [SerializeField] private float _delay = 0.8f;

    private void Start()
    {
        Destroy(gameObject, _delay);
    }
}