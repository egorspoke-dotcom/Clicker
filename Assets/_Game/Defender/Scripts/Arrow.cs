using UnityEngine;

namespace Defender
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private int _damage = 1;
        [SerializeField] private float _destroyDelay = 1.5f;

        private void Start()
        {
            Destroy(gameObject, _destroyDelay);
        }


        private void Update()
        {
            transform.position += transform.up * _speed * Time.deltaTime;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Enemy penek))
            {
                penek.TakeDamege(_damage);
            }

            Destroy(gameObject);
        }
    }
}