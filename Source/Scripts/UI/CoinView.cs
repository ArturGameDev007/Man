using TMPro;
using UnityEngine;

public class CoinView :MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private CoinManager _manager;

    private void OnEnable()
    {
        _manager.CoinChanged += OnCoinChanged;
    }

    private void OnDisable()
    {
        _manager.CoinChanged -= OnCoinChanged;
    }

    private void OnCoinChanged(int value)
    {
        _text.text = value.ToString();
    }
}
