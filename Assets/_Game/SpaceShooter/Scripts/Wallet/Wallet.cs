using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private int _star = 0;

    public int Star => _star;

    public void AddStar()
    {
        _star++;
    }
}