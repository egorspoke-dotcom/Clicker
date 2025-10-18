using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Vector3 _direction = Vector3.down;

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }
}