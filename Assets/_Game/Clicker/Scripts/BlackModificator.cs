using UnityEngine;

public class BlackModificator : MonoBehaviour
{
    [SerializeField] private float _sizeChangeStep = 0.9f;
    [SerializeField] private GameObject _trap;
    [SerializeField] private RandomMover _randomMover;
    [SerializeField] private float _speedChange = 0.5f;

    public void DecreseSize()
    {
        transform.localScale *= _sizeChangeStep;
    }

    public void Dublicate()
    {
        Instantiate(gameObject, transform.position, Quaternion.identity);
        Instantiate(_trap, _trap.transform.position, Quaternion.identity);
    }

    public void AddSpeed()
    {
        _randomMover.AddSpeed(_speedChange);
    }
}