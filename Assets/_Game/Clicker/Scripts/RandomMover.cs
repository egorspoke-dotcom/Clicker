using UnityEngine;

public class RandomMover : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Vector2 _targetPosition;
    [SerializeField] private float _xrange = 6.5f;
    [SerializeField] private float _yrange = 4.5f;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, _targetPosition) < 0.1f)
            GenerateNewTarget();
    }

    public void AddSpeed(float value)
    {
        _speed += value;
    }

    private void GenerateNewTarget()
    {
        _targetPosition = new Vector2(Random.Range(-_xrange, _xrange), Random.Range(-_yrange, _yrange));
    }
}