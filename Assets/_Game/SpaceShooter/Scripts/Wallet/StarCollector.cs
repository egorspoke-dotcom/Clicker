using UnityEngine;

public class StarCollector : MonoBehaviour
{
    [SerializeField] private GameObject _pickUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Wallet wallet))
        {
            wallet.AddStar();
            Instantiate(_pickUp, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}