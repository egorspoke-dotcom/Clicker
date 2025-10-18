using System.Collections;
using UnityEngine;

namespace Defender
{
    public class Crossbow : MonoBehaviour
    {
        [SerializeField] private Arrow _defaultArrow;
        [SerializeField] private float _shootInterval = 0.75f;

        private bool _isShootingCooldown = false;

        private void Update()
        {
            RotateTowardsMouse();
            HandleShooting();
        }

        private void HandleShooting()
        {
            if (!Input.GetMouseButton(0) || _isShootingCooldown)
            {
                return;
            }

            Shoot();
            StartCoroutine(ShootCooldown());
        }
        private void RotateTowardsMouse()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookDirection = mousePosition - (Vector2)transform.position;
            transform.up = lookDirection;
        }

        private void Shoot()
        {
            Instantiate(_defaultArrow, transform.position, transform.rotation);
        }

        private IEnumerator ShootCooldown()
        {
            _isShootingCooldown = true;
            yield return new WaitForSeconds(_shootInterval);
            _isShootingCooldown = false;
        }
    }
}