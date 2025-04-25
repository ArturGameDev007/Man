using System;
using TMPro;
using UnityEngine;

public class CoinManager :MonoBehaviour
{
    [Header("CoinText")]
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _coin;

    private int _bonusCoin = 20;

    public event Action<int> CoinChanged;

    private void Start()
    {
        _coin = Progress.Instance.Coin;
        _text.text = _coin.ToString();
    }

    public void Add()
    {
        _coin++;
        CoinChanged?.Invoke(_coin);
    }

    public void SaveToProgress()
    {
        Progress.Instance.Coin = _coin;
    }

    public void BonusCoin()
    {
        _coin += _bonusCoin;
        CoinChanged?.Invoke(_coin);
    }
}
