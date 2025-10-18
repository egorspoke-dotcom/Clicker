using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosotion = Input.mousePosition;
            Vector2 realPosotion = Camera.main.ScreenToWorldPoint(mousePosotion);
            transform.position = realPosotion;
        }
    }
}