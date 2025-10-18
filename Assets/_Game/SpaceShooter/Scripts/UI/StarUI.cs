using TMPro;
using UnityEngine;

public class StarUI : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private TextMeshProUGUI _starText;

    private void Update()
    {
        _starText.text = _wallet.Star.ToString();
    }
}
