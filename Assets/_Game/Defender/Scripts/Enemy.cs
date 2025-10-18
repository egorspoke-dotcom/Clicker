using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 1;
    [SerializeField] private int _killReward = 2;
    [SerializeField] private float _baseSpeed = 1f;
    [SerializeField] private float _speedPerLevel = 0.2f;
    [SerializeField] private float _attackInterval = 1f;
    [SerializeField] private int _damage = 1;

    public static List<Enemy> ActiveEnemies = new List<Enemy>();

    private float _currentSpeed;
    private bool _isMoving = true;
    private Coroutine _coroutine;
    private Corn _target;
    private float _borderPositionX;

    private void Start()
    {
        _currentSpeed = _baseSpeed + _speedPerLevel * LevelController.Level;
    }

    private void Update()
    {
        if (!_target) return;

        _isMoving = transform.position.x > _borderPositionX;

        if (_isMoving)
        {
            Move();
        }
        else if (_coroutine == null)
        {
            _coroutine = StartCoroutine(DelayAttack());
        }
    }

    private IEnumerator DelayAttack()
    {
        while (true)
        {
            yield return new WaitForSeconds(_attackInterval);
            _target.TakeDamage(_damage);
        }
    }

    private void Move()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
        transform.position += -transform.right * (_currentSpeed * Time.deltaTime);
    }

    private void OnEnable()
    {
        ActiveEnemies.Add(this);
    }

    private void OnDisable()
    {
        ActiveEnemies.Remove(this);
    }

    public void TakeDamege(int damage)
    {
        _health -= damage;
        if (_health < 0)
        {
            _target.AddCrystals(_killReward);
            Destroy(gameObject);
        }
    }

    public void SetTarget(Corn corn)
    {
        _target = corn;
        _borderPositionX = corn.transform.position.x;
    }
}